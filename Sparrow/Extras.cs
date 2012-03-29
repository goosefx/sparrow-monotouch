using System;
using System.Collections.Generic;
using MonoTouch.Foundation;
using MonoTouch.ObjCRuntime;
using MonoTouch.CoreGraphics;

namespace Sparrow
{
	#region SPColor

	public static class SPColor
	{
		public const uint White = 0xffffff;
		public const uint Silver = 0xc0c0c0;
		public const uint Gray = 0x808080;
		public const uint Black = 0x000000;
		public const uint Red = 0xff0000;
		public const uint Maroon = 0x800000;
		public const uint Yellow = 0xffff00;
		public const uint Olive = 0x808000;
		public const uint Lime = 0x00ff00;
		public const uint Green = 0x008000;
		public const uint Aqua = 0x00ffff;
		public const uint Teal = 0x008080;
		public const uint Blue = 0x0000ff;
		public const uint Navy = 0x000080;
		public const uint Fuchsia = 0xff00ff;
		public const uint Purple = 0x800080;
		
		public static byte GetAlpha(uint color)
		{
			return (byte)(((color) >> 24) & 0xff);
		}
		
		public static byte GetRed(uint color)
		{
			return (byte)(((color) >> 16) & 0xff);
		}
		
		public static byte GetGreen(uint color)
		{
			return (byte)(((color) >> 8) & 0xff);
		}
		
		public static byte GetBlue(uint color)
		{
			return (byte)(color & 0xff);
		}
		
		public static uint FromRGB(byte r, byte g, byte b)
		{
			return (uint)(((int)(r) << 16) | ((int)(g) << 8) | (int)(b));
		}
		
		public static uint FromRGBA(byte r, byte g, byte b, byte a)
		{
			return (uint)(((int)(a) << 24) | ((int)(r) << 16) | ((int)(g) << 8) | (int)(b));
		}
	}

	#endregion
	
	#region SPDisplayObject
	
	public partial class SPDisplayObject
	{
		public event SPEventHandler Added
		{
			add
			{
				this.AddEventListener(SPEventType.Added, value);
			}
			remove
			{
				this.RemoveEventListener(SPEventType.Added, value);
			}
		}

		public event SPEventHandler AddedToStage
		{
			add
			{
				this.AddEventListener(SPEventType.AddedToStage, value);
			}
			remove
			{
				this.RemoveEventListener(SPEventType.Added, value);
			}
		}

		public event SPEventHandler Removed
		{
			add
			{
				this.AddEventListener(SPEventType.Removed, value);
			}
			remove
			{
				this.RemoveEventListener(SPEventType.Removed, value);
			}
		}

		public event SPEventHandler RemovedFromStage
		{
			add
			{
				this.AddEventListener(SPEventType.RemovedFromStage, value);
			}
			remove
			{
				this.RemoveEventListener(SPEventType.RemovedFromStage, value);
			}
		}

	}
	
	#endregion
	
	#region SPDisplayObjectContainer

	public partial class SPDisplayObjectContainer : IList<SPDisplayObject>
	{
		bool ICollection<SPDisplayObject>.IsReadOnly
		{
			get { return false; }
		}
		
		public SPDisplayObject this[int index]
		{
			get { return this._ChildAtIndex(index); }
			set
			{ 
				this._AddAtIndex(value, index);
				
				int nextIndex = index + 1;
				
				if (nextIndex < this.Count)
				{
					this.RemoveAt(nextIndex);
				}
			}
		}

		public SPDisplayObject this[string name]
		{
			get { return this._ChildByName(name); }
		}

		public void Insert(int index, SPDisplayObject child)
		{
			this._AddAtIndex(child, index);
		}
		
		public bool Remove(SPDisplayObject child)
		{
			if (!this.Contains(child))
			{
				return false;
			}
			this._Remove(child);
			return true;
		}
		
		public void CopyTo(SPDisplayObject[] array, int arrayIndex)
		{
			int count = this.Count;
			for (int i = 0; i < count; i++)
			{
				array[arrayIndex + i] = this._ChildAtIndex(i);
			}
		}

		public IEnumerator<SPDisplayObject> GetEnumerator()
		{
			int num = this.Count;
			
			for (int i = 0; i < num; i++)
			{
				SPDisplayObject child = this._ChildAtIndex(i);
				yield return child;
			}
		}

		System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
	}
	
	#endregion
	
	#region SPEvent
	
	public static class SPEventType
	{
		public const string Added = "added";
		public const string AddedToStage = "addedToStage";
		public const string Removed = "removed";
		public const string RemovedFromStage = "removedFromStage";
		public const string Touch = "touch";
		public const string EnterFrame = "enterFrame";
	}
	
	public interface SPEventArgs
	{
		string EventType
		{
			get;
		}
		
		bool Bubbles
		{
			get;
			set;
		}
		
		bool Cancel
		{
			get;
			set;
		}
		
		SPEventDispatcher Origin
		{
			get;
		}
	}
	
	public partial class SPEvent : SPEventArgs
	{
		bool SPEventArgs.Bubbles
		{
			get
			{
				if (this._StopsPropagation())
				{
					return false;
				}
				return this.Bubbles;
			}
			set
			{
				if (!value)
				{
					this.StopPropagation();
				}
				else if (this._StopsPropagation())
				{
					throw new InvalidOperationException();
				}
			}
		}
		
		bool SPEventArgs.Cancel
		{
			get
			{
				if (this._StopsImmediatePropagation())
				{
					return true;
				}
				return false;
			}
			set
			{
				if (value)
				{
					this.StopImmediatePropagation();
				}
				else if (this._StopsImmediatePropagation())
				{
					throw new InvalidOperationException();
				}
			}
		}
		
		SPEventDispatcher SPEventArgs.Origin
		{
			get
			{ 
				return this.Target;
			}
		}
		
	}
	
	#endregion
	
	#region SPEventDispatcher
	
	// Internal
	[Register("__SPEventDispatcherInvocationTarget")]
	public class SPEventDispatcherInvocationTarget : NSObject
	{
		public static readonly Selector InvokeSelector = new Selector("invoke:");
		internal WeakReference WeakEventHandler;
		internal List<string> EventTypes = new List<string>();
		
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
		
		// while we try to find a matching invocation target for the given event handler we do
		// some cleanup (for disposed objects)
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
	
	#endregion
	
	#region SPMatrix
	
	public partial class SPMatrix : ICloneable
	{
		public override int GetHashCode()
		{
			return (int)(this.A + this.B + this.C + this.D + this.Tx + this.Ty);
		}
		
		public override bool Equals(object other)
		{
			if (ReferenceEquals(other, null))
			{
				return false;
			}	
			return this._IsEqual((NSObject)other);
		}
		
		public override string ToString()
		{
			return string.Format("{{A={0}, B={1}, C={2}, D={3}, Tx={4}, Ty={5}}}",
			                     this.A.ToString(System.Globalization.CultureInfo.InvariantCulture), 
			                     this.B.ToString(System.Globalization.CultureInfo.InvariantCulture), 
			                     this.C.ToString(System.Globalization.CultureInfo.InvariantCulture), 
			                     this.D.ToString(System.Globalization.CultureInfo.InvariantCulture), 
			                     this.Tx.ToString(System.Globalization.CultureInfo.InvariantCulture), 
			                     this.Ty.ToString(System.Globalization.CultureInfo.InvariantCulture));
		}
		
		public SPMatrix Clone()
		{
			return new SPMatrix(this.A, this.B, this.C, this.D, this.Tx, this.Ty);
		}
		
		public static bool operator ==(SPMatrix m1, SPMatrix m2)
		{
			if (ReferenceEquals(m1, m2))
			{
				return true;
			}
			if (ReferenceEquals(m1, null) || ReferenceEquals(m2, null))
			{
				return false;
			}
    		
			return m1._IsEqual(m2);
		}
		
		public static bool operator !=(SPMatrix m1, SPMatrix m2)
		{
			if (ReferenceEquals(m1, m2))
			{
				return false;
			}
			if (ReferenceEquals(m1, null) || ReferenceEquals(m2, null))
			{
				return true;
			}
    		
			return !m1._IsEqual(m2);
		}

		#region ICloneable implementation
		object ICloneable.Clone()
		{
			return this.Clone();
		}
		#endregion

	}
	
	#endregion
	
	#region SPPoint

	public partial class SPPoint
	{	
		public override bool Equals(object other)
		{
			if (ReferenceEquals(other, null))
			{
				return false;
			}	
			return this._IsEqual((NSObject)other);
		}
		
		public override int GetHashCode()
		{
			return (int)this.X ^ (int)this.Y;
		}
		
		public override string ToString()
		{
			return string.Format("{{X={0}, Y={1}}}", this.X.ToString(System.Globalization.CultureInfo.InvariantCulture), 
			                                         this.Y.ToString(System.Globalization.CultureInfo.InvariantCulture));
		}
		
		public static SPPoint operator +(SPPoint p1, SPPoint p2)
		{
			return p1._AddPoint(p2);
		}
		
		public static SPPoint operator -(SPPoint p1, SPPoint p2)
		{
			return p1._SubtractPoint(p2);
		}
		
		public static SPPoint operator *(SPPoint p1, float scalar)
		{
			return p1.Scale(scalar);
		}
		
		public static bool operator ==(SPPoint p1, SPPoint p2)
		{
			if (ReferenceEquals(p1, p2))
			{
				return true;
			}
			if (ReferenceEquals(p1, null) || ReferenceEquals(p2, null))
			{
				return false;
			}
    		
			return p1._IsEqual(p2);
		}
		
		public static bool operator !=(SPPoint p1, SPPoint p2)
		{
			if (ReferenceEquals(p1, p2))
			{
				return false;
			}
			if (ReferenceEquals(p1, null) || ReferenceEquals(p2, null))
			{
				return true;
			}
    		
			return !p1._IsEqual(p2);
		}
		
		public static implicit operator System.Drawing.PointF(SPPoint p)
		{
			return new System.Drawing.PointF(p.X, p.Y);
		}
		
		public static implicit operator SPPoint(System.Drawing.PointF p)
		{
			return new SPPoint(p.X, p.Y);
		}
   
	}
	
	#endregion

	#region SPQuad

	public partial class SPQuad
	{
		public SPQuad() : this(32.0f, 32.0f, SPColor.White)
		{
		}
	}
	
	#endregion
	
	#region SPRectangle

	public partial class SPRectangle : ICloneable
	{
		public static SPRectangle FromLTRB(float left, float top, float right, float bottom)
		{
			return new SPRectangle(left, top, right - left, bottom - top);
		}
		
		public SPPoint Center
		{
			get
			{
				return new SPPoint(this.X + (this.Width / 2.0f),
				                   this.Y + (this.Height / 2.0f));
			}
			set
			{
				this.X = value.X - (this.Width / 2.0f);
				this.Y = value.Y - (this.Height / 2.0f);
			}
		}

		public SPRectangle(SPPoint location, float width, float height) : this(location.X, location.Y, width, height)
		{
		}

		public SPRectangle(SPPoint topLeft, SPPoint bottomRight) : this(topLeft.X, topLeft.Y, 
		                                                                bottomRight.X - topLeft.X,
		                                                                bottomRight.Y - topLeft.Y)
		{
		}
		
		public void Offset(float x, float y)
		{
			this.X += x;
			this.Y += y;
		}
		
		public void Offset(SPPoint pos)
		{
			this.Offset(pos.X, pos.Y);
		}
		
		public SPRectangle Inflate(float x, float y)
		{
			return new SPRectangle(this.X - x, this.Y - y, 
			                       this.Width + (x * 2.0f),
			                       this.Height + (y * 2.0f));
		}

		public SPRectangle Inflate(SPPoint size)
		{
			return this.Inflate(size.X, size.Y);
			//
			// TODO: The next statement produce "funny" results, but why? A Bug?
			//
			// return new SPRectangle(this.X - Size.X, this.Y - size.Y, 
			//                        this.Width + (Size.X * 2.0f),
			//                        this.Height + (Size.Y * 2.0f));
		}
		
		public override bool Equals(object other)
		{
			if (ReferenceEquals(other, null))
			{
				return false;
			}
			
			SPRectangle otherRect = other as SPRectangle;
			
			if (ReferenceEquals(otherRect, null))
			{
				return false;
			}
			
			return this.X == otherRect.X && this.Y == otherRect.Y &&
			       this.Width == otherRect.Width &&
			       this.Height == otherRect.Height; 
		}
		
		public override int GetHashCode()
		{
			return (int)(this.X + this.Y + this.Width + this.Height);
		}
		
		public override string ToString()
		{
			return string.Format("{{X={0}, Y={1}, Width={2}, Height={3}}}", 
			                     this.X.ToString(System.Globalization.CultureInfo.InvariantCulture), 
			                     this.Y.ToString(System.Globalization.CultureInfo.InvariantCulture), 
			                     this.Width.ToString(System.Globalization.CultureInfo.InvariantCulture), 
			                     this.Height.ToString(System.Globalization.CultureInfo.InvariantCulture));
		}
		
		public SPRectangle Clone()
		{
			return new SPRectangle(this.X, this.Y, this.Width, this.Height);
		}
		
		public static SPRectangle operator +(SPRectangle r1, SPRectangle r2)
		{
			return r1.Union(r2);
		}

		public static bool operator ==(SPRectangle r1, SPRectangle r2)
		{
			if (ReferenceEquals(r1, r2))
			{
				return true;
			}
			if (ReferenceEquals(r1, null))
			{
				return false;
			}
    		
			return r1.Equals(r2);
		}
		
		public static bool operator !=(SPRectangle r1, SPRectangle r2)
		{
			if (ReferenceEquals(r1, r2))
			{
				return false;
			}
			if (ReferenceEquals(r1, null))
			{
				return true;
			}
    		
			return !r1.Equals(r2);
		}
		
		public static implicit operator System.Drawing.RectangleF(SPRectangle r)
		{
			return new System.Drawing.RectangleF(r.X, r.Y, r.Width, r.Height);
		}
		
		public static implicit operator SPRectangle(System.Drawing.RectangleF r)
		{
			return new SPRectangle(r.X, r.Y, r.Width, r.Height);
		}
   		
		#region ICloneable implementation
		object ICloneable.Clone()
		{
			return this.Clone();
		}
		#endregion
	}
	
	#endregion
	
	#region SPStage

	public partial class SPStage
	{
		public static bool DoubleResolutionsOnPad
		{
			get
			{
				return _DoubleResolutionsOnPad;	
			}
			set
			{
				_SetSupportHighResolutions(SupportHighResolutions, value);
			}
		}
	}
	
	#endregion
	
	#region SPTextField

	public partial class SPTextField
	{
		public const string DefaultFontName = "Helvetica";
		public const float DefaultFontSize = 14.0f;
		public const uint DefaultFontColor = SPColor.Black;
		public const float NativeFontSize = -1.0f;
	}
	
	#endregion
	
	#region SPTexture

	public delegate void SPTextureDrawingDelegate(CGContext context);
	
	public partial class SPTexture
	{
		private static _SPTextureDrawingDelegate InternalDrawingDelegate(SPTextureDrawingDelegate drawingDelegate)
		{
			// TODO: check for memory leaks
			return delegate(IntPtr contextHandle) {
				
				CGContext context = new CGContext(contextHandle);
				drawingDelegate(context);
				context.Dispose(); // TODO: is dispose here ok?
				context = null;
			};
		}
	
		public SPTexture(float width, float height, SPTextureDrawingDelegate drawingDelegate) :
			this(width, height, InternalDrawingDelegate(drawingDelegate))
		{
			
		}

		public SPTexture(float width, float height, float scale, SPColorSpace colorSpace, SPTextureDrawingDelegate drawingDelegate) :
				this(width, height, scale, colorSpace, InternalDrawingDelegate(drawingDelegate))
		{
			
		}
		
		public void AdjustTextureCoordinates(ref float[] texCoords, ref float[] targetTextCoords, int numVertices)
		{
			unsafe
			{
				fixed (float* pTexCoords = texCoords, pTargetTextCoords = targetTextCoords)
				{
					this._AdjustTextureCoordinates(new IntPtr((void*)pTexCoords), new IntPtr((void*)pTargetTextCoords), numVertices);
				}
		
			}
		}
		
	}
	
	#endregion
}