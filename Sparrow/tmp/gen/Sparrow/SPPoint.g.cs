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
	[Register("SPPoint", true)]
	public partial class SPPoint : SPPoolObject {
		static IntPtr selX = Selector.GetHandle ("x");
		static IntPtr selSetX_ = Selector.GetHandle ("setX:");
		static IntPtr selY = Selector.GetHandle ("y");
		static IntPtr selSetY_ = Selector.GetHandle ("setY:");
		static IntPtr selLength = Selector.GetHandle ("length");
		static IntPtr selLengthSquared = Selector.GetHandle ("lengthSquared");
		static IntPtr selAngle = Selector.GetHandle ("angle");
		static IntPtr selIsOrigin = Selector.GetHandle ("isOrigin");
		static IntPtr selPointWithPolarLengthAngle_ = Selector.GetHandle ("pointWithPolarLength:angle:");
		static IntPtr selDistanceFromPointToPoint_ = Selector.GetHandle ("distanceFromPoint:toPoint:");
		static IntPtr selAngleBetweenPointAndPoint_ = Selector.GetHandle ("angleBetweenPoint:andPoint:");
		static IntPtr selInterpolateFromPointToPointRatio_ = Selector.GetHandle ("interpolateFromPoint:toPoint:ratio:");
		static IntPtr selPurgePool = Selector.GetHandle ("purgePool");
		static IntPtr selInitWithXY_ = Selector.GetHandle ("initWithX:y:");
		static IntPtr selAddPoint_ = Selector.GetHandle ("addPoint:");
		static IntPtr selSubtractPoint_ = Selector.GetHandle ("subtractPoint:");
		static IntPtr selScaleBy_ = Selector.GetHandle ("scaleBy:");
		static IntPtr selRotateBy_ = Selector.GetHandle ("rotateBy:");
		static IntPtr selNormalize = Selector.GetHandle ("normalize");
		static IntPtr selInvert = Selector.GetHandle ("invert");
		static IntPtr selDot_ = Selector.GetHandle ("dot:");
		static IntPtr selIsEqual_ = Selector.GetHandle ("isEqual:");
		
		static IntPtr class_ptr = Class.GetHandle ("SPPoint");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[Export ("initWithCoder:")]
		public SPPoint (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::Sparrow.Messaging.this_assembly;
			if (IsDirectBinding) {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.InitWithCoder, coder.Handle);
			} else {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.InitWithCoder, coder.Handle);
			}
		}

		public SPPoint (NSObjectFlag t) : base (t) {}

		public SPPoint (IntPtr handle) : base (handle) {}

		[Export ("pointWithPolarLength:angle:")]
		public static SPPoint FromPolarLength (float length, float angle)
		{
			return (SPPoint) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_float_float (class_ptr, selPointWithPolarLengthAngle_, length, angle));
		}
		
		[Export ("distanceFromPoint:toPoint:")]
		public static float CalculateDistance (SPPoint p1, SPPoint p2)
		{
			if (p1 == null)
				throw new ArgumentNullException ("p1");
			if (p2 == null)
				throw new ArgumentNullException ("p2");
			return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSend_IntPtr_IntPtr (class_ptr, selDistanceFromPointToPoint_, p1.Handle, p2.Handle);
		}
		
		[Export ("angleBetweenPoint:andPoint:")]
		public static float CalculateAngle (SPPoint p1, SPPoint p2)
		{
			if (p1 == null)
				throw new ArgumentNullException ("p1");
			if (p2 == null)
				throw new ArgumentNullException ("p2");
			return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSend_IntPtr_IntPtr (class_ptr, selAngleBetweenPointAndPoint_, p1.Handle, p2.Handle);
		}
		
		[Export ("interpolateFromPoint:toPoint:ratio:")]
		public static SPPoint Interpolate (SPPoint p1, SPPoint p2, float ratio)
		{
			if (p1 == null)
				throw new ArgumentNullException ("p1");
			if (p2 == null)
				throw new ArgumentNullException ("p2");
			return (SPPoint) Runtime.GetNSObject (Sparrow.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_float (class_ptr, selInterpolateFromPointToPointRatio_, p1.Handle, p2.Handle, ratio));
		}
		
		[Export ("purgePool")]
		public static int PurgePool ()
		{
			return MonoTouch.ObjCRuntime.Messaging.int_objc_msgSend (class_ptr, selPurgePool);
		}
		
		[Export ("initWithX:y:")]
		public SPPoint (float x, float y) : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::Sparrow.Messaging.this_assembly;
			if (IsDirectBinding) {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_float_float (this.Handle, selInitWithXY_, x, y);
			} else {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_float_float (this.SuperHandle, selInitWithXY_, x, y);
			}
		}
		
		[Export ("addPoint:")]
		internal virtual SPPoint _AddPoint (SPPoint point)
		{
			if (point == null)
				throw new ArgumentNullException ("point");
			if (IsDirectBinding) {
				return (SPPoint) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, selAddPoint_, point.Handle));
			} else {
				return (SPPoint) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, selAddPoint_, point.Handle));
			}
		}
		
		[Export ("subtractPoint:")]
		internal virtual SPPoint _SubtractPoint (SPPoint point)
		{
			if (point == null)
				throw new ArgumentNullException ("point");
			if (IsDirectBinding) {
				return (SPPoint) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, selSubtractPoint_, point.Handle));
			} else {
				return (SPPoint) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, selSubtractPoint_, point.Handle));
			}
		}
		
		[Export ("scaleBy:")]
		public virtual SPPoint Scale (float scalar)
		{
			if (IsDirectBinding) {
				return (SPPoint) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_float (this.Handle, selScaleBy_, scalar));
			} else {
				return (SPPoint) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_float (this.SuperHandle, selScaleBy_, scalar));
			}
		}
		
		[Export ("rotateBy:")]
		public virtual SPPoint Rotate (float angle)
		{
			if (IsDirectBinding) {
				return (SPPoint) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_float (this.Handle, selRotateBy_, angle));
			} else {
				return (SPPoint) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_float (this.SuperHandle, selRotateBy_, angle));
			}
		}
		
		[Export ("normalize")]
		public virtual SPPoint Normalize ()
		{
			if (IsDirectBinding) {
				return (SPPoint) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selNormalize));
			} else {
				return (SPPoint) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selNormalize));
			}
		}
		
		[Export ("invert")]
		public virtual SPPoint Invert ()
		{
			if (IsDirectBinding) {
				return (SPPoint) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selInvert));
			} else {
				return (SPPoint) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selInvert));
			}
		}
		
		[Export ("dot:")]
		public virtual float Dot (SPPoint other)
		{
			if (other == null)
				throw new ArgumentNullException ("other");
			if (IsDirectBinding) {
				return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSend_IntPtr (this.Handle, selDot_, other.Handle);
			} else {
				return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSendSuper_IntPtr (this.SuperHandle, selDot_, other.Handle);
			}
		}
		
		[Export ("isEqual:")]
		internal virtual bool _IsEqual (NSObject other)
		{
			if (other == null)
				throw new ArgumentNullException ("other");
			if (IsDirectBinding) {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend_IntPtr (this.Handle, selIsEqual_, other.Handle);
			} else {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper_IntPtr (this.SuperHandle, selIsEqual_, other.Handle);
			}
		}
		
		public virtual float X {
			[Export ("x", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selX);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSendSuper (this.SuperHandle, selX);
				}
			}
			
			[Export ("setX:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, selSetX_, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_float (this.SuperHandle, selSetX_, value);
				}
			}
		}
		
		public virtual float Y {
			[Export ("y", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selY);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSendSuper (this.SuperHandle, selY);
				}
			}
			
			[Export ("setY:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, selSetY_, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_float (this.SuperHandle, selSetY_, value);
				}
			}
		}
		
		public virtual float Length {
			[Export ("length", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selLength);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSendSuper (this.SuperHandle, selLength);
				}
			}
			
		}
		
		public virtual float LengthSquared {
			[Export ("lengthSquared")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selLengthSquared);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSendSuper (this.SuperHandle, selLengthSquared);
				}
			}
			
		}
		
		public virtual float Angle {
			[Export ("angle")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selAngle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSendSuper (this.SuperHandle, selAngle);
				}
			}
			
		}
		
		public virtual bool IsOrigin {
			[Export ("isOrigin")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsOrigin);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selIsOrigin);
				}
			}
			
		}
		
	} /* class SPPoint */
}
