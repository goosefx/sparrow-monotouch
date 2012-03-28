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
	[Register("SPEventDispatcher", true)]
	public partial class SPEventDispatcher : NSObject {
		static IntPtr selAddEventListenerAtObjectForTypeRetainObject_ = Selector.GetHandle ("addEventListener:atObject:forType:retainObject:");
		static IntPtr selAddEventListenerAtObjectForType_ = Selector.GetHandle ("addEventListener:atObject:forType:");
		static IntPtr selRemoveEventListenerAtObjectForType_ = Selector.GetHandle ("removeEventListener:atObject:forType:");
		static IntPtr selDispatchEvent_ = Selector.GetHandle ("dispatchEvent:");
		static IntPtr selHasEventListenerForType_ = Selector.GetHandle ("hasEventListenerForType:");
		
		static IntPtr class_ptr = Class.GetHandle ("SPEventDispatcher");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[Export ("initWithCoder:")]
		public SPEventDispatcher (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::Sparrow.Messaging.this_assembly;
			if (IsDirectBinding) {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.InitWithCoder, coder.Handle);
			} else {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.InitWithCoder, coder.Handle);
			}
		}

		public SPEventDispatcher (NSObjectFlag t) : base (t) {}

		public SPEventDispatcher (IntPtr handle) : base (handle) {}

		[Export ("addEventListener:atObject:forType:retainObject:")]
		internal virtual void _AddEventListener (Selector listener, NSObject object_, string eventType, bool retain)
		{
			if (listener == null)
				throw new ArgumentNullException ("listener");
			if (object_ == null)
				throw new ArgumentNullException ("object_");
			if (eventType == null)
				throw new ArgumentNullException ("eventType");
			var nseventType = new NSString (eventType);
			
			if (IsDirectBinding) {
				Sparrow.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_bool (this.Handle, selAddEventListenerAtObjectForTypeRetainObject_, listener.Handle, object_.Handle, nseventType.Handle, retain);
			} else {
				Sparrow.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_bool (this.SuperHandle, selAddEventListenerAtObjectForTypeRetainObject_, listener.Handle, object_.Handle, nseventType.Handle, retain);
			}
			nseventType.Dispose ();
			
		}
		
		[Export ("addEventListener:atObject:forType:")]
		internal virtual void _AddEventListener (Selector listener, NSObject object_, string eventType)
		{
			if (listener == null)
				throw new ArgumentNullException ("listener");
			if (object_ == null)
				throw new ArgumentNullException ("object_");
			if (eventType == null)
				throw new ArgumentNullException ("eventType");
			var nseventType = new NSString (eventType);
			
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr (this.Handle, selAddEventListenerAtObjectForType_, listener.Handle, object_.Handle, nseventType.Handle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr (this.SuperHandle, selAddEventListenerAtObjectForType_, listener.Handle, object_.Handle, nseventType.Handle);
			}
			nseventType.Dispose ();
			
		}
		
		[Export ("removeEventListener:atObject:forType:")]
		internal virtual void _RemoveEventListener (Selector listener, NSObject object_, string eventType)
		{
			if (listener == null)
				throw new ArgumentNullException ("listener");
			if (object_ == null)
				throw new ArgumentNullException ("object_");
			if (eventType == null)
				throw new ArgumentNullException ("eventType");
			var nseventType = new NSString (eventType);
			
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr (this.Handle, selRemoveEventListenerAtObjectForType_, listener.Handle, object_.Handle, nseventType.Handle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr (this.SuperHandle, selRemoveEventListenerAtObjectForType_, listener.Handle, object_.Handle, nseventType.Handle);
			}
			nseventType.Dispose ();
			
		}
		
		[Export ("dispatchEvent:")]
		public virtual void DispatchEvent (SPEvent event_)
		{
			if (event_ == null)
				throw new ArgumentNullException ("event_");
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selDispatchEvent_, event_.Handle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selDispatchEvent_, event_.Handle);
			}
		}
		
		[Export ("hasEventListenerForType:")]
		public virtual void HasEventListener (string eventType)
		{
			if (eventType == null)
				throw new ArgumentNullException ("eventType");
			var nseventType = new NSString (eventType);
			
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selHasEventListenerForType_, nseventType.Handle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selHasEventListenerForType_, nseventType.Handle);
			}
			nseventType.Dispose ();
			
		}
		
	} /* class SPEventDispatcher */
}
