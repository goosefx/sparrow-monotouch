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
	[Register("SPView", true)]
	public partial class SPView : MonoTouch.UIKit.UIView {
		static IntPtr selIsStarted = Selector.GetHandle ("isStarted");
		static IntPtr selFrameRate = Selector.GetHandle ("frameRate");
		static IntPtr selSetFrameRate_ = Selector.GetHandle ("setFrameRate:");
		static IntPtr selStage = Selector.GetHandle ("stage");
		static IntPtr selSetStage_ = Selector.GetHandle ("setStage:");
		static IntPtr selInitWithFrame_ = Selector.GetHandle ("initWithFrame:");
		static IntPtr selStart = Selector.GetHandle ("start");
		static IntPtr selStop = Selector.GetHandle ("stop");
		
		static IntPtr class_ptr = Class.GetHandle ("SPView");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[Export ("init")]
		public  SPView () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::Sparrow.Messaging.this_assembly;
			if (IsDirectBinding) {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.Init);
			} else {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.Init);
			}
		}

		[Export ("initWithCoder:")]
		public SPView (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::Sparrow.Messaging.this_assembly;
			if (IsDirectBinding) {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.InitWithCoder, coder.Handle);
			} else {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.InitWithCoder, coder.Handle);
			}
		}

		public SPView (NSObjectFlag t) : base (t) {}

		public SPView (IntPtr handle) : base (handle) {}

		[Export ("initWithFrame:")]
		public SPView (System.Drawing.RectangleF frame) : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::Sparrow.Messaging.this_assembly;
			if (IsDirectBinding) {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_RectangleF (this.Handle, selInitWithFrame_, frame);
			} else {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_RectangleF (this.SuperHandle, selInitWithFrame_, frame);
			}
		}
		
		[Export ("start")]
		public virtual void Start ()
		{
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selStart);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper (this.SuperHandle, selStart);
			}
		}
		
		[Export ("stop")]
		public virtual void Stop ()
		{
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selStop);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper (this.SuperHandle, selStop);
			}
		}
		
		public virtual bool IsStarted {
			[Export ("isStarted")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsStarted);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selIsStarted);
				}
			}
			
		}
		
		public virtual float FrameRate {
			[Export ("frameRate", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selFrameRate);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSendSuper (this.SuperHandle, selFrameRate);
				}
			}
			
			[Export ("setFrameRate:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, selSetFrameRate_, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_float (this.SuperHandle, selSetFrameRate_, value);
				}
			}
		}
		
		object __mt_Stage_var;
		public virtual SPStage Stage {
			[Export ("stage", ArgumentSemantic.Retain)]
			get {
				SPStage ret;
				if (IsDirectBinding) {
					ret = (SPStage) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selStage));
				} else {
					ret = (SPStage) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selStage));
				}
				if (!IsNewRefcountEnabled ())
					__mt_Stage_var = ret;
				return ret;
			}
			
			[Export ("setStage:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetStage_, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetStage_, value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_Stage_var = value;
			}
		}
		
		protected override void Dispose (bool disposing)
		{
			__mt_Stage_var = null;
			base.Dispose (disposing);
		}
	} /* class SPView */
}
