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
	[Register("SPQuad", true)]
	public partial class SPQuad : SPDisplayObject {
		static IntPtr selColor = Selector.GetHandle ("color");
		static IntPtr selSetColor_ = Selector.GetHandle ("setColor:");
		static IntPtr selInitWithWidthHeightColor_ = Selector.GetHandle ("initWithWidth:height:color:");
		static IntPtr selInitWithWidthHeight_ = Selector.GetHandle ("initWithWidth:height:");
		static IntPtr selSetColorOfVertex_ = Selector.GetHandle ("setColor:ofVertex:");
		static IntPtr selColorOfVertex_ = Selector.GetHandle ("colorOfVertex:");
		
		static IntPtr class_ptr = Class.GetHandle ("SPQuad");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[Export ("initWithCoder:")]
		public SPQuad (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::Sparrow.Messaging.this_assembly;
			if (IsDirectBinding) {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.InitWithCoder, coder.Handle);
			} else {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.InitWithCoder, coder.Handle);
			}
		}

		public SPQuad (NSObjectFlag t) : base (t) {}

		public SPQuad (IntPtr handle) : base (handle) {}

		[Export ("initWithWidth:height:color:")]
		public SPQuad (float width, float height, System.UInt32 color) : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::Sparrow.Messaging.this_assembly;
			if (IsDirectBinding) {
				Handle = Sparrow.Messaging.IntPtr_objc_msgSend_float_float_UInt32 (this.Handle, selInitWithWidthHeightColor_, width, height, color);
			} else {
				Handle = Sparrow.Messaging.IntPtr_objc_msgSendSuper_float_float_UInt32 (this.SuperHandle, selInitWithWidthHeightColor_, width, height, color);
			}
		}
		
		[Export ("initWithWidth:height:")]
		public SPQuad (float width, float height) : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::Sparrow.Messaging.this_assembly;
			if (IsDirectBinding) {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_float_float (this.Handle, selInitWithWidthHeight_, width, height);
			} else {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_float_float (this.SuperHandle, selInitWithWidthHeight_, width, height);
			}
		}
		
		[Export ("setColor:ofVertex:")]
		public virtual void SetColor (System.UInt32 color, int vertexID)
		{
			if (IsDirectBinding) {
				Sparrow.Messaging.void_objc_msgSend_UInt32_int (this.Handle, selSetColorOfVertex_, color, vertexID);
			} else {
				Sparrow.Messaging.void_objc_msgSendSuper_UInt32_int (this.SuperHandle, selSetColorOfVertex_, color, vertexID);
			}
		}
		
		[Export ("colorOfVertex:")]
		public virtual System.UInt32 GetColor (int vertexID)
		{
			if (IsDirectBinding) {
				return MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSend_int (this.Handle, selColorOfVertex_, vertexID);
			} else {
				return MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSendSuper_int (this.SuperHandle, selColorOfVertex_, vertexID);
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
		
	} /* class SPQuad */
}
