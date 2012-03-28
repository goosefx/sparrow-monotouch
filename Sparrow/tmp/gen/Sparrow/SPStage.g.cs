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
	[Register("SPStage", true)]
	public partial class SPStage : SPDisplayObjectContainer {
		static IntPtr selMainStage = Selector.GetHandle ("mainStage");
		static IntPtr selSupportHighResolutions = Selector.GetHandle ("supportHighResolutions");
		static IntPtr selSetSupportHighResolutions_ = Selector.GetHandle ("setSupportHighResolutions:");
		static IntPtr selDoubleResolutionsOnPad = Selector.GetHandle ("doubleResolutionsOnPad");
		static IntPtr selContentScaleFactor = Selector.GetHandle ("contentScaleFactor");
		static IntPtr selFrameRate = Selector.GetHandle ("frameRate");
		static IntPtr selSetFrameRate_ = Selector.GetHandle ("setFrameRate:");
		static IntPtr selColor = Selector.GetHandle ("color");
		static IntPtr selSetColor_ = Selector.GetHandle ("setColor:");
		static IntPtr selJuggler = Selector.GetHandle ("juggler");
		static IntPtr selNativeView = Selector.GetHandle ("nativeView");
		static IntPtr selSetSupportHighResolutionsDoubleOnPad_ = Selector.GetHandle ("setSupportHighResolutions:doubleOnPad:");
		static IntPtr selInit = Selector.GetHandle ("init");
		static IntPtr selInitWithWidthHeight_ = Selector.GetHandle ("initWithWidth:height:");
		static IntPtr selAdvanceTime_ = Selector.GetHandle ("advanceTime:");
		static IntPtr selProcessTouches_ = Selector.GetHandle ("processTouches:");
		
		static IntPtr class_ptr = Class.GetHandle ("SPStage");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[Export ("initWithCoder:")]
		public SPStage (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::Sparrow.Messaging.this_assembly;
			if (IsDirectBinding) {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.InitWithCoder, coder.Handle);
			} else {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.InitWithCoder, coder.Handle);
			}
		}

		public SPStage (NSObjectFlag t) : base (t) {}

		public SPStage (IntPtr handle) : base (handle) {}

		[Export ("setSupportHighResolutions:doubleOnPad:")]
		internal static void _SetSupportHighResolutions (bool hd, bool doubleOnPad)
		{
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool_bool (class_ptr, selSetSupportHighResolutionsDoubleOnPad_, hd, doubleOnPad);
		}
		
		[Export ("init")]
		public SPStage () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::Sparrow.Messaging.this_assembly;
			if (IsDirectBinding) {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selInit);
			} else {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selInit);
			}
		}
		
		[Export ("initWithWidth:height:")]
		public SPStage (float width, float height) : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::Sparrow.Messaging.this_assembly;
			if (IsDirectBinding) {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_float_float (this.Handle, selInitWithWidthHeight_, width, height);
			} else {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_float_float (this.SuperHandle, selInitWithWidthHeight_, width, height);
			}
		}
		
		[Export ("advanceTime:")]
		public virtual void AdvanceTime (System.Double seconds)
		{
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_Double (this.Handle, selAdvanceTime_, seconds);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_Double (this.SuperHandle, selAdvanceTime_, seconds);
			}
		}
		
		[Export ("processTouches:")]
		public virtual void ProcessTouches (NSSet touches)
		{
			if (touches == null)
				throw new ArgumentNullException ("touches");
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selProcessTouches_, touches.Handle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selProcessTouches_, touches.Handle);
			}
		}
		
		static object __mt_MainStage_var_static;
		public static SPStage MainStage {
			[Export ("mainStage")]
			get {
				SPStage ret;
				ret = (SPStage) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (class_ptr, selMainStage));
				__mt_MainStage_var_static = ret;
				return ret;
			}
			
		}
		
		public static bool SupportHighResolutions {
			[Export ("supportHighResolutions")]
			get {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (class_ptr, selSupportHighResolutions);
			}
			
			[Export ("setSupportHighResolutions:")]
			set {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (class_ptr, selSetSupportHighResolutions_, value);
			}
		}
		
		internal static bool _DoubleResolutionsOnPad {
			[Export ("doubleResolutionsOnPad")]
			get {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (class_ptr, selDoubleResolutionsOnPad);
			}
			
		}
		
		public static float ContentScaleFactor {
			[Export ("contentScaleFactor")]
			get {
				return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSend (class_ptr, selContentScaleFactor);
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
		
		public virtual System.UInt32 Color {
			[Export ("color", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSend (this.Handle, selColor);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, selColor);
				}
			}
			
			[Export ("setColor:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_UInt32 (this.Handle, selSetColor_, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_UInt32 (this.SuperHandle, selSetColor_, value);
				}
			}
		}
		
		object __mt_Juggler_var;
		public virtual SPJuggler Juggler {
			[Export ("juggler")]
			get {
				SPJuggler ret;
				if (IsDirectBinding) {
					ret = (SPJuggler) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selJuggler));
				} else {
					ret = (SPJuggler) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selJuggler));
				}
				MarkDirty ();
				__mt_Juggler_var = ret;
				return ret;
			}
			
		}
		
		object __mt_NativeView_var;
		public virtual SPView NativeView {
			[Export ("nativeView")]
			get {
				SPView ret;
				if (IsDirectBinding) {
					ret = (SPView) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selNativeView));
				} else {
					ret = (SPView) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selNativeView));
				}
				MarkDirty ();
				__mt_NativeView_var = ret;
				return ret;
			}
			
		}
		
		protected override void Dispose (bool disposing)
		{
			__mt_Juggler_var = null;
			__mt_NativeView_var = null;
			base.Dispose (disposing);
		}
	} /* class SPStage */
}
