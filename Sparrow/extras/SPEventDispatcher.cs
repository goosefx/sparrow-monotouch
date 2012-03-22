using System;
using System.Collections.Generic;

using MonoTouch.Foundation;
using MonoTouch.ObjCRuntime;

namespace Sparrow
{
	// Internal
	[Register("__SPEventDispatcherInvocationTarget")]
	public class SPEventDispatcherInvocationTarget : NSObject
	{
		public static readonly Selector InvokeSelector = new Selector("invoke:");
		
		internal WeakReference WeakEventHandler;
		internal List<string> EventTypes = new List<string>();
		internal bool InvalidTarget = false;
		
		internal SPEventDispatcherInvocationTarget(Delegate eventHandler)
		{
			this.WeakEventHandler = new WeakReference(eventHandler);
		}
		
		[Export("invoke:"), Preserve(Conditional = true)]
		internal void Invoke(SPEvent e)
		{
			if (this.WeakEventHandler.IsAlive)
			{
				((Delegate)this.WeakEventHandler.Target).DynamicInvoke(new object[] { e.CurrentTarget, e }); 
			}
			else
			{
				this.InvalidTarget = true;
			}
		}
		
		/// For Testing
		public Delegate GetEventHandler()
		{
			if (this.WeakEventHandler.IsAlive)
			{
				return (Delegate)this.WeakEventHandler.Target;
			}
			return null;
		}
		
		// For Testing
		public string[] GetEventTypes()
		{
			return this.EventTypes.ToArray();
		}
	}
	
	public delegate void SPEventHandler(SPEventDispatcher source, SPEventArgs e);
		
	public partial class SPEventDispatcher
	{
		private List<SPEventDispatcherInvocationTarget> invocationTargets = null;
		
		private bool TryGetInvocationTarget(Delegate eventHandler, out SPEventDispatcherInvocationTarget target)
		{
			List<SPEventDispatcherInvocationTarget> invalidTargets = null;
			bool result = false;
			target = null;
			
			if (this.invocationTargets != null)
			{
				foreach (SPEventDispatcherInvocationTarget item in this.invocationTargets)
				{
					if (!item.WeakEventHandler.IsAlive)
					{
						if (invalidTargets == null)
						{
							invalidTargets = new List<SPEventDispatcherInvocationTarget>(4);
						}
						
						invalidTargets.Add(item);
					}
					else if (((Delegate)item.WeakEventHandler.Target) == eventHandler)
					{
						target = item;
						result = true;
						
						break;
					}
				}
			}
			
			if (invalidTargets != null)
			{
				foreach (SPEventDispatcherInvocationTarget invalidTarget in invalidTargets)
				{
					this.invocationTargets.Remove(invalidTarget);
					
					foreach (string eventType in invalidTarget.EventTypes)
					{
						this._RemoveEventListener(SPEventDispatcherInvocationTarget.InvokeSelector,
					                              invalidTarget, eventType);
					}
				}
			}
			return result;
		}
		
		public void AddEventListener(string eventType, Delegate eventHandler)
		{
			AddEventListener(eventType, eventHandler, false);
		}

		public void AddEventListener(string eventType, Delegate eventHandler, bool retain)
		{
			SPEventDispatcherInvocationTarget target = null;
			
			if (!this.TryGetInvocationTarget(eventHandler, out target))
			{
				target = new SPEventDispatcherInvocationTarget(eventHandler);
				
				if (this.invocationTargets == null)
				{
					this.invocationTargets = new List<SPEventDispatcherInvocationTarget>(4);
				}
				this.invocationTargets.Add(target);
				
			}
			
			if (!target.EventTypes.Contains(eventType))
			{
				target.EventTypes.Add(eventType);
				
				if (retain)
				{
					this._AddEventListener(SPEventDispatcherInvocationTarget.InvokeSelector, 
					                       target, eventType, true);
				}
				else
				{
					this._AddEventListener(SPEventDispatcherInvocationTarget.InvokeSelector, 
					                       target, eventType);
				}
			}
		}
		
		public bool RemoveEventListener(string eventType, Delegate eventHandler)
		{
			SPEventDispatcherInvocationTarget target = null;
			
			if (this.TryGetInvocationTarget(eventHandler, out target))
			{
				if (target.EventTypes.Contains(eventType))
				{
					target.EventTypes.Remove(eventType);
					
					this._RemoveEventListener(SPEventDispatcherInvocationTarget.InvokeSelector,
					                          target, eventType);
					
					if (target.EventTypes.Count == 0)
					{
						this.invocationTargets.Remove(target);
					}
					
					if (this.invocationTargets.Count == 0)
					{
						this.invocationTargets = null;
					}
					
					return true;
					
				}
			}
			return false;
		}
		
		// For Testing
		public SPEventDispatcherInvocationTarget[] GetInvocationList()
		{
			if (this.invocationTargets == null)
			{
				return null;
			}
			
			return this.invocationTargets.ToArray();			
		}
		
		protected override void Dispose(bool disposing)
		{
			if (this.invocationTargets != null)
			{
				this.invocationTargets.Clear();
				this.invocationTargets = null;
			}
			
			base.Dispose(disposing);
		}
	}
}

