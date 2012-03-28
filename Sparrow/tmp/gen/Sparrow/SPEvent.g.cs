//
// Auto-generated from generator.cs, do not edit
//
// We keep references to objects, so warning 414 is expected

#pragma warning disable 414

using System;

using System.Drawing;

using System.Runtime.InteropServices;

using MonoTouch;

using MonoTouch.CoreFoundation;

using MonoTouch.CoreMedia;

using MonoTouch.CoreMotion;

using MonoTouch.Foundation;

using MonoTouch.ObjCRuntime;

using MonoTouch.CoreAnimation;

using MonoTouch.CoreLocation;

using MonoTouch.MapKit;

using MonoTouch.UIKit;

using MonoTouch.CoreGraphics;

using MonoTouch.NewsstandKit;

using MonoTouch.GLKit;

using OpenTK;

namespace Sparrow {
	[Register("SPEvent", true)]
	public partial class SPEvent : NSObject {
		static IntPtr selType = Selector.GetHandle ("type");
		static IntPtr selBubbles = Selector.GetHandle ("bubbles");
		static IntPtr selTarget = Selector.GetHandle ("target");
		static IntPtr selCurrentTarget = Selector.GetHandle ("currentTarget");
		static IntPtr selInitWithTypeBubbles_ = Selector.GetHandle ("initWithType:bubbles:");
		static IntPtr selInitWithType_ = Selector.GetHandle ("initWithType:");
		static IntPtr selStopImmediatePropagation = Selector.GetHandle ("stopImmediatePropagation");
		static IntPtr selStopPropagation = Selector.GetHandle ("stopPropagation");
		static IntPtr selStopsImmediatePropagation = Selector.GetHandle ("stopsImmediatePropagation");
		static IntPtr selStopsPropagation = Selector.GetHandle ("stopsPropagation");
		
		static IntPtr class_ptr = Class.GetHandle ("SPEvent");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[Export ("initWithCoder:")]
		public SPEvent (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::Sparrow.Messaging.this_assembly;
			if (IsDirectBinding) {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.InitWithCoder, coder.Handle);
			} else {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.InitWithCoder, coder.Handle);
			}
		}

		public SPEvent (NSObjectFlag t) : base (t) {}

		public SPEvent (IntPtr handle) : base (handle) {}

		[Export ("initWithType:bubbles:")]
		public SPEvent (string eventType, bool bubbles) : base (NSObjectFlag.Empty)
		{
			if (eventType == null)
				throw new ArgumentNullException ("eventType");
			var nseventType = new NSString (eventType);
			
			IsDirectBinding = GetType ().Assembly == global::Sparrow.Messaging.this_assembly;
			if (IsDirectBinding) {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_bool (this.Handle, selInitWithTypeBubbles_, nseventType.Handle, bubbles);
			} else {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr_bool (this.SuperHandle, selInitWithTypeBubbles_, nseventType.Handle, bubbles);
			}
			nseventType.Dispose ();
			
		}
		
		[Export ("initWithType:")]
		public SPEvent (string eventType) : base (NSObjectFlag.Empty)
		{
			if (eventType == null)
				throw new ArgumentNullException ("eventType");
			var nseventType = new NSString (eventType);
			
			IsDirectBinding = GetType ().Assembly == global::Sparrow.Messaging.this_assembly;
			if (IsDirectBinding) {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, selInitWithType_, nseventType.Handle);
			} else {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, selInitWithType_, nseventType.Handle);
			}
			nseventType.Dispose ();
			
		}
		
		[Export ("stopImmediatePropagation")]
		public virtual void StopImmediatePropagation ()
		{
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selStopImmediatePropagation);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper (this.SuperHandle, selStopImmediatePropagation);
			}
		}
		
		[Export ("stopPropagation")]
		public virtual void StopPropagation ()
		{
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selStopPropagation);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper (this.SuperHandle, selStopPropagation);
			}
		}
		
		[Export ("stopsImmediatePropagation")]
		internal virtual bool _StopsImmediatePropagation ()
		{
			if (IsDirectBinding) {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selStopsImmediatePropagation);
			} else {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selStopsImmediatePropagation);
			}
		}
		
		[Export ("stopsPropagation")]
		internal virtual bool _StopsPropagation ()
		{
			if (IsDirectBinding) {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selStopsPropagation);
			} else {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selStopsPropagation);
			}
		}
		
		public virtual string EventType {
			[Export ("type")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selType));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selType));
				}
			}
			
		}
		
		public virtual bool Bubbles {
			[Export ("bubbles")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selBubbles);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selBubbles);
				}
			}
			
		}
		
		object __mt_Target_var;
		public virtual SPEventDispatcher Target {
			[Export ("target")]
			get {
				SPEventDispatcher ret;
				if (IsDirectBinding) {
					ret = (SPEventDispatcher) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selTarget));
				} else {
					ret = (SPEventDispatcher) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selTarget));
				}
				MarkDirty ();
				__mt_Target_var = ret;
				return ret;
			}
			
		}
		
		object __mt_CurrentTarget_var;
		public virtual SPEventDispatcher CurrentTarget {
			[Export ("currentTarget")]
			get {
				SPEventDispatcher ret;
				if (IsDirectBinding) {
					ret = (SPEventDispatcher) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selCurrentTarget));
				} else {
					ret = (SPEventDispatcher) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selCurrentTarget));
				}
				MarkDirty ();
				__mt_CurrentTarget_var = ret;
				return ret;
			}
			
		}
		
		protected override void Dispose (bool disposing)
		{
			__mt_Target_var = null;
			__mt_CurrentTarget_var = null;
			base.Dispose (disposing);
		}
	} /* class SPEvent */
}
