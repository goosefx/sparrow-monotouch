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
	[Register("SPTexture", true)]
	public partial class SPTexture : NSObject {
		static IntPtr selInitWithWidthHeightDraw_ = Selector.GetHandle ("initWithWidth:height:draw:");
		static IntPtr selInitWithWidthHeightScaleColorSpaceDraw_ = Selector.GetHandle ("initWithWidth:height:scale:colorSpace:draw:");
		static IntPtr selInitWithContentsOfFile_ = Selector.GetHandle ("initWithContentsOfFile:");
		static IntPtr selInitWithContentsOfImage_ = Selector.GetHandle ("initWithContentsOfImage:");
		static IntPtr selInitWithRegionOfTexture_ = Selector.GetHandle ("initWithRegion:ofTexture:");
		
		static IntPtr class_ptr = Class.GetHandle ("SPTexture");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[Export ("initWithCoder:")]
		public SPTexture (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::Sparrow.Messaging.this_assembly;
			if (IsDirectBinding) {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.InitWithCoder, coder.Handle);
			} else {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.InitWithCoder, coder.Handle);
			}
		}

		public SPTexture (NSObjectFlag t) : base (t) {}

		public SPTexture (IntPtr handle) : base (handle) {}

		[Export ("initWithWidth:height:draw:")]
		internal unsafe SPTexture (float width, float height, _SPTextureDrawingDelegate drawingDelegate) : base (NSObjectFlag.Empty)
		{
			if (drawingDelegate == null)
				throw new ArgumentNullException ("drawingDelegate");
			BlockLiteral *block_ptr_drawingDelegate;
			BlockLiteral block_drawingDelegate;
			block_drawingDelegate = new BlockLiteral ();
			block_ptr_drawingDelegate = &block_drawingDelegate;
			block_drawingDelegate.SetupBlock (static_Inner_SPTextureDrawingDelegate, drawingDelegate);
			
			IsDirectBinding = GetType ().Assembly == global::Sparrow.Messaging.this_assembly;
			if (IsDirectBinding) {
				Handle = Sparrow.Messaging.IntPtr_objc_msgSend_float_float_IntPtr (this.Handle, selInitWithWidthHeightDraw_, width, height, (IntPtr) block_ptr_drawingDelegate);
			} else {
				Handle = Sparrow.Messaging.IntPtr_objc_msgSendSuper_float_float_IntPtr (this.SuperHandle, selInitWithWidthHeightDraw_, width, height, (IntPtr) block_ptr_drawingDelegate);
			}
			block_ptr_drawingDelegate->CleanupBlock ();
			
		}
		
		[Export ("initWithWidth:height:scale:colorSpace:draw:")]
		internal unsafe SPTexture (float width, float height, float scale, SPColorSpace colorSpace, _SPTextureDrawingDelegate drawingDelegate) : base (NSObjectFlag.Empty)
		{
			if (drawingDelegate == null)
				throw new ArgumentNullException ("drawingDelegate");
			BlockLiteral *block_ptr_drawingDelegate;
			BlockLiteral block_drawingDelegate;
			block_drawingDelegate = new BlockLiteral ();
			block_ptr_drawingDelegate = &block_drawingDelegate;
			block_drawingDelegate.SetupBlock (static_Inner_SPTextureDrawingDelegate, drawingDelegate);
			
			IsDirectBinding = GetType ().Assembly == global::Sparrow.Messaging.this_assembly;
			if (IsDirectBinding) {
				Handle = Sparrow.Messaging.IntPtr_objc_msgSend_float_float_float_int_IntPtr (this.Handle, selInitWithWidthHeightScaleColorSpaceDraw_, width, height, scale, (int)colorSpace, (IntPtr) block_ptr_drawingDelegate);
			} else {
				Handle = Sparrow.Messaging.IntPtr_objc_msgSendSuper_float_float_float_int_IntPtr (this.SuperHandle, selInitWithWidthHeightScaleColorSpaceDraw_, width, height, scale, (int)colorSpace, (IntPtr) block_ptr_drawingDelegate);
			}
			block_ptr_drawingDelegate->CleanupBlock ();
			
		}
		
		[Export ("initWithContentsOfFile:")]
		public SPTexture (string path) : base (NSObjectFlag.Empty)
		{
			if (path == null)
				throw new ArgumentNullException ("path");
			var nspath = new NSString (path);
			
			IsDirectBinding = GetType ().Assembly == global::Sparrow.Messaging.this_assembly;
			if (IsDirectBinding) {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, selInitWithContentsOfFile_, nspath.Handle);
			} else {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, selInitWithContentsOfFile_, nspath.Handle);
			}
			nspath.Dispose ();
			
		}
		
		[Export ("initWithContentsOfImage:")]
		public SPTexture (MonoTouch.UIKit.UIImage image) : base (NSObjectFlag.Empty)
		{
			if (image == null)
				throw new ArgumentNullException ("image");
			IsDirectBinding = GetType ().Assembly == global::Sparrow.Messaging.this_assembly;
			if (IsDirectBinding) {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, selInitWithContentsOfImage_, image.Handle);
			} else {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, selInitWithContentsOfImage_, image.Handle);
			}
		}
		
		[Export ("initWithRegion:ofTexture:")]
		public SPTexture (SPRectangle region, SPTexture texture) : base (NSObjectFlag.Empty)
		{
			if (region == null)
				throw new ArgumentNullException ("region");
			if (texture == null)
				throw new ArgumentNullException ("texture");
			IsDirectBinding = GetType ().Assembly == global::Sparrow.Messaging.this_assembly;
			if (IsDirectBinding) {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (this.Handle, selInitWithRegionOfTexture_, region.Handle, texture.Handle);
			} else {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, selInitWithRegionOfTexture_, region.Handle, texture.Handle);
			}
		}
		
		internal delegate void Inner_SPTextureDrawingDelegate (IntPtr block, System.IntPtr context);
		static Inner_SPTextureDrawingDelegate static_Inner_SPTextureDrawingDelegate = new Inner_SPTextureDrawingDelegate (Trampoline_SPTextureDrawingDelegate);
		[MonoPInvokeCallback (typeof (Inner_SPTextureDrawingDelegate))]
		static unsafe void Trampoline_SPTextureDrawingDelegate (IntPtr block, System.IntPtr context) {
			var descriptor = (BlockLiteral *) block;
			var del = (Sparrow._SPTextureDrawingDelegate) (descriptor->global_handle != IntPtr.Zero ? GCHandle.FromIntPtr (descriptor->global_handle).Target : GCHandle.FromIntPtr (descriptor->local_handle).Target);
			del (context);
		}
		
	} /* class SPTexture */
	public delegate void _SPTextureDrawingDelegate (System.IntPtr context);
}
