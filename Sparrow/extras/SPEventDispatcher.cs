using System;
using System.Collections.Generic;

using MonoTouch.Foundation;
using MonoTouch.ObjCRuntime;

namespace Sparrow
{
	[Register("__SPEventDispatcherInvocationTarget")]
	public class SPEventDispatcherInvocationTarget : NSObject
	{
		public static readonly Selector InvokeSelector = new Selector("invoke:");
		
		internal SPEventHandler EventHandler;
		internal List<string> EventTypes = new List<string>();
		
		internal SPEventDispatcherInvocationTarget(SPEventHandler eventHandler)
		{
			this.EventHandler = eventHandler;
		}
		
		[Export("invoke:"), Preserve(Conditional = true)]
		internal void Invoke(SPEvent e)
		{
			this.EventHandler(e.CurrentTarget, (SPEventArgs)e); 
		}
		
		/// <summary>
		/// For Testing: Gets the event handler.
		/// </summary>
		public SPEventHandler GetEventHandler()
		{
			return this.EventHandler;
		}
		
		/// <summary>
		/// For Testing: Gets the event types.
		/// </summary>
		public string[] GetEventTypes()
		{
			return this.EventTypes.ToArray();
		}
	}
	
	public delegate void SPEventHandler(SPEventDispatcher source, SPEventArgs e);
	
	public partial class SPEventDispatcher
	{
		private List<SPEventDispatcherInvocationTarget> invocationTargets = null;
		
		private bool TryGetInvocationTarget(SPEventHandler eventHandler, out SPEventDispatcherInvocationTarget target)
		{
			if (this.invocationTargets != null)
			{
				foreach (SPEventDispatcherInvocationTarget item in this.invocationTargets)
				{
					if (item.EventHandler == eventHandler)
					{
						target = item;
						return true;
					}
				}
			}
			
			target = null;
			return false;
		}
		
		/// <summary>
		/// Registers an event listener without retaining it (recommended).
		/// </summary>
		public void AddEventListener(string eventType, SPEventHandler eventHandler)
		{
			AddEventListener(eventType, eventHandler, false);
		}

		/// <summary>
		/// Registers an event listener. 
		/// </summary>
		public void AddEventListener(string eventType, SPEventHandler eventHandler, bool retain)
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
		
		/// <summary>
		/// Removes an event listener.
		/// </summary>
		public bool RemoveEventListener(string eventType, SPEventHandler eventHandler)
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
						target.EventHandler = null;
						target = null;
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
		
		/// <summary>
		/// For Testing: Gets the (managed) invocation list.
		/// </summary>
		public SPEventDispatcherInvocationTarget[] GetInvocationList()
		{
			if (this.invocationTargets == null)
			{
				return null;
			}
			
			return this.invocationTargets.ToArray();			
		}
		

	}
}

