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
	[Register("SPMatrix", true)]
	public partial class SPMatrix : SPPoolObject {
		static IntPtr selA = Selector.GetHandle ("a");
		static IntPtr selSetA_ = Selector.GetHandle ("setA:");
		static IntPtr selB = Selector.GetHandle ("b");
		static IntPtr selSetB_ = Selector.GetHandle ("setB:");
		static IntPtr selC = Selector.GetHandle ("c");
		static IntPtr selSetC_ = Selector.GetHandle ("setC:");
		static IntPtr selD = Selector.GetHandle ("d");
		static IntPtr selSetD_ = Selector.GetHandle ("setD:");
		static IntPtr selTx = Selector.GetHandle ("tx");
		static IntPtr selSetTx_ = Selector.GetHandle ("setTx:");
		static IntPtr selTy = Selector.GetHandle ("ty");
		static IntPtr selSetTy_ = Selector.GetHandle ("setTy:");
		static IntPtr selDeterminant = Selector.GetHandle ("determinant");
		static IntPtr selPurgePool = Selector.GetHandle ("purgePool");
		static IntPtr selInitWithABCDTxTy_ = Selector.GetHandle ("initWithA:b:c:d:tx:ty:");
		static IntPtr selInit = Selector.GetHandle ("init");
		static IntPtr selSetABCDTxTy_ = Selector.GetHandle ("setA:b:c:d:tx:ty:");
		static IntPtr selIsEqual_ = Selector.GetHandle ("isEqual:");
		static IntPtr selConcatMatrix_ = Selector.GetHandle ("concatMatrix:");
		static IntPtr selTranslateXByYBy_ = Selector.GetHandle ("translateXBy:yBy:");
		static IntPtr selScaleXByYBy_ = Selector.GetHandle ("scaleXBy:yBy:");
		static IntPtr selScaleBy_ = Selector.GetHandle ("scaleBy:");
		static IntPtr selRotateBy_ = Selector.GetHandle ("rotateBy:");
		static IntPtr selIdentity = Selector.GetHandle ("identity");
		static IntPtr selInvert = Selector.GetHandle ("invert");
		static IntPtr selTransformPoint_ = Selector.GetHandle ("transformPoint:");
		
		static IntPtr class_ptr = Class.GetHandle ("SPMatrix");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[Export ("initWithCoder:")]
		public SPMatrix (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::Sparrow.Messaging.this_assembly;
			if (IsDirectBinding) {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.InitWithCoder, coder.Handle);
			} else {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.InitWithCoder, coder.Handle);
			}
		}

		public SPMatrix (NSObjectFlag t) : base (t) {}

		public SPMatrix (IntPtr handle) : base (handle) {}

		[Export ("purgePool")]
		public static int PurgePool ()
		{
			return MonoTouch.ObjCRuntime.Messaging.int_objc_msgSend (class_ptr, selPurgePool);
		}
		
		[Export ("initWithA:b:c:d:tx:ty:")]
		public SPMatrix (float a, float b, float c, float d, float tx, float ty) : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::Sparrow.Messaging.this_assembly;
			if (IsDirectBinding) {
				Handle = Sparrow.Messaging.IntPtr_objc_msgSend_float_float_float_float_float_float (this.Handle, selInitWithABCDTxTy_, a, b, c, d, tx, ty);
			} else {
				Handle = Sparrow.Messaging.IntPtr_objc_msgSendSuper_float_float_float_float_float_float (this.SuperHandle, selInitWithABCDTxTy_, a, b, c, d, tx, ty);
			}
		}
		
		[Export ("init")]
		public SPMatrix () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::Sparrow.Messaging.this_assembly;
			if (IsDirectBinding) {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selInit);
			} else {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selInit);
			}
		}
		
		[Export ("setA:b:c:d:tx:ty:")]
		public virtual void Set (float a, float b, float c, float d, float tx, float ty)
		{
			if (IsDirectBinding) {
				Sparrow.Messaging.void_objc_msgSend_float_float_float_float_float_float (this.Handle, selSetABCDTxTy_, a, b, c, d, tx, ty);
			} else {
				Sparrow.Messaging.void_objc_msgSendSuper_float_float_float_float_float_float (this.SuperHandle, selSetABCDTxTy_, a, b, c, d, tx, ty);
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
		
		[Export ("concatMatrix:")]
		public virtual void Concat (SPMatrix matrix)
		{
			if (matrix == null)
				throw new ArgumentNullException ("matrix");
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selConcatMatrix_, matrix.Handle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selConcatMatrix_, matrix.Handle);
			}
		}
		
		[Export ("translateXBy:yBy:")]
		public virtual void Translate (float dx, float dy)
		{
			if (IsDirectBinding) {
				Sparrow.Messaging.void_objc_msgSend_float_float (this.Handle, selTranslateXByYBy_, dx, dy);
			} else {
				Sparrow.Messaging.void_objc_msgSendSuper_float_float (this.SuperHandle, selTranslateXByYBy_, dx, dy);
			}
		}
		
		[Export ("scaleXBy:yBy:")]
		public virtual void Scale (float sx, float sy)
		{
			if (IsDirectBinding) {
				Sparrow.Messaging.void_objc_msgSend_float_float (this.Handle, selScaleXByYBy_, sx, sy);
			} else {
				Sparrow.Messaging.void_objc_msgSendSuper_float_float (this.SuperHandle, selScaleXByYBy_, sx, sy);
			}
		}
		
		[Export ("scaleBy:")]
		public virtual void Scale (float scale)
		{
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, selScaleBy_, scale);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_float (this.SuperHandle, selScaleBy_, scale);
			}
		}
		
		[Export ("rotateBy:")]
		public virtual void Rotate (float angle)
		{
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, selRotateBy_, angle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_float (this.SuperHandle, selRotateBy_, angle);
			}
		}
		
		[Export ("identity")]
		public virtual void SetIdentity ()
		{
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selIdentity);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper (this.SuperHandle, selIdentity);
			}
		}
		
		[Export ("invert")]
		public virtual void Invert ()
		{
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selInvert);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper (this.SuperHandle, selInvert);
			}
		}
		
		[Export ("transformPoint:")]
		public virtual SPPoint Transform (SPPoint point)
		{
			if (point == null)
				throw new ArgumentNullException ("point");
			if (IsDirectBinding) {
				return (SPPoint) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, selTransformPoint_, point.Handle));
			} else {
				return (SPPoint) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, selTransformPoint_, point.Handle));
			}
		}
		
		public virtual float A {
			[Export ("a", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selA);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSendSuper (this.SuperHandle, selA);
				}
			}
			
			[Export ("setA:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, selSetA_, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_float (this.SuperHandle, selSetA_, value);
				}
			}
		}
		
		public virtual float B {
			[Export ("b", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selB);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSendSuper (this.SuperHandle, selB);
				}
			}
			
			[Export ("setB:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, selSetB_, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_float (this.SuperHandle, selSetB_, value);
				}
			}
		}
		
		public virtual float C {
			[Export ("c", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selC);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSendSuper (this.SuperHandle, selC);
				}
			}
			
			[Export ("setC:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, selSetC_, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_float (this.SuperHandle, selSetC_, value);
				}
			}
		}
		
		public virtual float D {
			[Export ("d", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selD);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSendSuper (this.SuperHandle, selD);
				}
			}
			
			[Export ("setD:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, selSetD_, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_float (this.SuperHandle, selSetD_, value);
				}
			}
		}
		
		public virtual float Tx {
			[Export ("tx", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selTx);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSendSuper (this.SuperHandle, selTx);
				}
			}
			
			[Export ("setTx:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, selSetTx_, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_float (this.SuperHandle, selSetTx_, value);
				}
			}
		}
		
		public virtual float Ty {
			[Export ("ty", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selTy);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSendSuper (this.SuperHandle, selTy);
				}
			}
			
			[Export ("setTy:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, selSetTy_, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_float (this.SuperHandle, selSetTy_, value);
				}
			}
		}
		
		public virtual float Determinant {
			[Export ("determinant")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selDeterminant);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSendSuper (this.SuperHandle, selDeterminant);
				}
			}
			
		}
		
	} /* class SPMatrix */
}
