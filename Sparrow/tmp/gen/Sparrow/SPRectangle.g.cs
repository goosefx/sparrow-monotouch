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
	[Register("SPRectangle", true)]
	public partial class SPRectangle : SPPoolObject {
		static IntPtr selX = Selector.GetHandle ("x");
		static IntPtr selSetX_ = Selector.GetHandle ("setX:");
		static IntPtr selY = Selector.GetHandle ("y");
		static IntPtr selSetY_ = Selector.GetHandle ("setY:");
		static IntPtr selWidth = Selector.GetHandle ("width");
		static IntPtr selSetWidth_ = Selector.GetHandle ("setWidth:");
		static IntPtr selHeight = Selector.GetHandle ("height");
		static IntPtr selSetHeight_ = Selector.GetHandle ("setHeight:");
		static IntPtr selTop = Selector.GetHandle ("top");
		static IntPtr selSetTop_ = Selector.GetHandle ("setTop:");
		static IntPtr selBottom = Selector.GetHandle ("bottom");
		static IntPtr selSetBottom_ = Selector.GetHandle ("setBottom:");
		static IntPtr selLeft = Selector.GetHandle ("left");
		static IntPtr selSetLeft_ = Selector.GetHandle ("setLeft:");
		static IntPtr selRight = Selector.GetHandle ("right");
		static IntPtr selSetRight_ = Selector.GetHandle ("setRight:");
		static IntPtr selTopLeft = Selector.GetHandle ("topLeft");
		static IntPtr selSetTopLeft_ = Selector.GetHandle ("setTopLeft:");
		static IntPtr selBottomRight = Selector.GetHandle ("bottomRight");
		static IntPtr selSetBottomRight_ = Selector.GetHandle ("setBottomRight:");
		static IntPtr selSize = Selector.GetHandle ("size");
		static IntPtr selSetSize_ = Selector.GetHandle ("setSize:");
		static IntPtr selIsEmpty = Selector.GetHandle ("isEmpty");
		static IntPtr selPurgePool = Selector.GetHandle ("purgePool");
		static IntPtr selInitWithXYWidthHeight_ = Selector.GetHandle ("initWithX:y:width:height:");
		static IntPtr selContainsXY_ = Selector.GetHandle ("containsX:y:");
		static IntPtr selContainsPoint_ = Selector.GetHandle ("containsPoint:");
		static IntPtr selContainsRectangle_ = Selector.GetHandle ("containsRectangle:");
		static IntPtr selIntersectsRectangle_ = Selector.GetHandle ("intersectsRectangle:");
		static IntPtr selIntersectionWithRectangle_ = Selector.GetHandle ("intersectionWithRectangle:");
		static IntPtr selUniteWithRectangle_ = Selector.GetHandle ("uniteWithRectangle:");
		static IntPtr selSetEmpty = Selector.GetHandle ("setEmpty");
		
		static IntPtr class_ptr = Class.GetHandle ("SPRectangle");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[Export ("initWithCoder:")]
		public SPRectangle (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::Sparrow.Messaging.this_assembly;
			if (IsDirectBinding) {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.InitWithCoder, coder.Handle);
			} else {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.InitWithCoder, coder.Handle);
			}
		}

		public SPRectangle (NSObjectFlag t) : base (t) {}

		public SPRectangle (IntPtr handle) : base (handle) {}

		[Export ("purgePool")]
		public static int PurgePool ()
		{
			return MonoTouch.ObjCRuntime.Messaging.int_objc_msgSend (class_ptr, selPurgePool);
		}
		
		[Export ("initWithX:y:width:height:")]
		public SPRectangle (float x, float y, float width, float height) : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::Sparrow.Messaging.this_assembly;
			if (IsDirectBinding) {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_float_float_float_float (this.Handle, selInitWithXYWidthHeight_, x, y, width, height);
			} else {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_float_float_float_float (this.SuperHandle, selInitWithXYWidthHeight_, x, y, width, height);
			}
		}
		
		[Export ("containsX:y:")]
		public virtual bool Contains (float x, float y)
		{
			if (IsDirectBinding) {
				return Sparrow.Messaging.bool_objc_msgSend_float_float (this.Handle, selContainsXY_, x, y);
			} else {
				return Sparrow.Messaging.bool_objc_msgSendSuper_float_float (this.SuperHandle, selContainsXY_, x, y);
			}
		}
		
		[Export ("containsPoint:")]
		public virtual bool Contains (SPPoint point)
		{
			if (point == null)
				throw new ArgumentNullException ("point");
			if (IsDirectBinding) {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend_IntPtr (this.Handle, selContainsPoint_, point.Handle);
			} else {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper_IntPtr (this.SuperHandle, selContainsPoint_, point.Handle);
			}
		}
		
		[Export ("containsRectangle:")]
		public virtual bool Contains (SPRectangle rectangle)
		{
			if (rectangle == null)
				throw new ArgumentNullException ("rectangle");
			if (IsDirectBinding) {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend_IntPtr (this.Handle, selContainsRectangle_, rectangle.Handle);
			} else {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper_IntPtr (this.SuperHandle, selContainsRectangle_, rectangle.Handle);
			}
		}
		
		[Export ("intersectsRectangle:")]
		public virtual bool IntersectsWith (SPRectangle rectangle)
		{
			if (rectangle == null)
				throw new ArgumentNullException ("rectangle");
			if (IsDirectBinding) {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend_IntPtr (this.Handle, selIntersectsRectangle_, rectangle.Handle);
			} else {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper_IntPtr (this.SuperHandle, selIntersectsRectangle_, rectangle.Handle);
			}
		}
		
		[Export ("intersectionWithRectangle:")]
		public virtual SPRectangle Intersect (SPRectangle rectangle)
		{
			if (rectangle == null)
				throw new ArgumentNullException ("rectangle");
			if (IsDirectBinding) {
				return (SPRectangle) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, selIntersectionWithRectangle_, rectangle.Handle));
			} else {
				return (SPRectangle) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, selIntersectionWithRectangle_, rectangle.Handle));
			}
		}
		
		[Export ("uniteWithRectangle:")]
		public virtual SPRectangle Union (SPRectangle rectangle)
		{
			if (rectangle == null)
				throw new ArgumentNullException ("rectangle");
			if (IsDirectBinding) {
				return (SPRectangle) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, selUniteWithRectangle_, rectangle.Handle));
			} else {
				return (SPRectangle) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, selUniteWithRectangle_, rectangle.Handle));
			}
		}
		
		[Export ("setEmpty")]
		public virtual void SetEmpty ()
		{
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selSetEmpty);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper (this.SuperHandle, selSetEmpty);
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
		
		public virtual float Width {
			[Export ("width", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selWidth);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSendSuper (this.SuperHandle, selWidth);
				}
			}
			
			[Export ("setWidth:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, selSetWidth_, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_float (this.SuperHandle, selSetWidth_, value);
				}
			}
		}
		
		public virtual float Height {
			[Export ("height", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selHeight);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSendSuper (this.SuperHandle, selHeight);
				}
			}
			
			[Export ("setHeight:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, selSetHeight_, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_float (this.SuperHandle, selSetHeight_, value);
				}
			}
		}
		
		public virtual float Top {
			[Export ("top", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selTop);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSendSuper (this.SuperHandle, selTop);
				}
			}
			
			[Export ("setTop:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, selSetTop_, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_float (this.SuperHandle, selSetTop_, value);
				}
			}
		}
		
		public virtual float Bottom {
			[Export ("bottom", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selBottom);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSendSuper (this.SuperHandle, selBottom);
				}
			}
			
			[Export ("setBottom:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, selSetBottom_, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_float (this.SuperHandle, selSetBottom_, value);
				}
			}
		}
		
		public virtual float Left {
			[Export ("left", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selLeft);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSendSuper (this.SuperHandle, selLeft);
				}
			}
			
			[Export ("setLeft:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, selSetLeft_, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_float (this.SuperHandle, selSetLeft_, value);
				}
			}
		}
		
		public virtual float Right {
			[Export ("right", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selRight);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSendSuper (this.SuperHandle, selRight);
				}
			}
			
			[Export ("setRight:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, selSetRight_, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_float (this.SuperHandle, selSetRight_, value);
				}
			}
		}
		
		object __mt_TopLeft_var;
		public virtual SPPoint TopLeft {
			[Export ("topLeft", ArgumentSemantic.Copy)]
			get {
				SPPoint ret;
				if (IsDirectBinding) {
					ret = (SPPoint) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selTopLeft));
				} else {
					ret = (SPPoint) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selTopLeft));
				}
				if (!IsNewRefcountEnabled ())
					__mt_TopLeft_var = ret;
				return ret;
			}
			
			[Export ("setTopLeft:", ArgumentSemantic.Copy)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetTopLeft_, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetTopLeft_, value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_TopLeft_var = value;
			}
		}
		
		object __mt_Location_var;
		public virtual SPPoint Location {
			[Export ("topLeft", ArgumentSemantic.Copy)]
			get {
				SPPoint ret;
				if (IsDirectBinding) {
					ret = (SPPoint) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selTopLeft));
				} else {
					ret = (SPPoint) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selTopLeft));
				}
				if (!IsNewRefcountEnabled ())
					__mt_Location_var = ret;
				return ret;
			}
			
			[Export ("setTopLeft:", ArgumentSemantic.Copy)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetTopLeft_, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetTopLeft_, value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_Location_var = value;
			}
		}
		
		object __mt_BottomRight_var;
		public virtual SPPoint BottomRight {
			[Export ("bottomRight", ArgumentSemantic.Copy)]
			get {
				SPPoint ret;
				if (IsDirectBinding) {
					ret = (SPPoint) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selBottomRight));
				} else {
					ret = (SPPoint) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selBottomRight));
				}
				if (!IsNewRefcountEnabled ())
					__mt_BottomRight_var = ret;
				return ret;
			}
			
			[Export ("setBottomRight:", ArgumentSemantic.Copy)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetBottomRight_, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetBottomRight_, value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_BottomRight_var = value;
			}
		}
		
		object __mt_Size_var;
		public virtual SPPoint Size {
			[Export ("size", ArgumentSemantic.Copy)]
			get {
				SPPoint ret;
				if (IsDirectBinding) {
					ret = (SPPoint) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selSize));
				} else {
					ret = (SPPoint) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selSize));
				}
				if (!IsNewRefcountEnabled ())
					__mt_Size_var = ret;
				return ret;
			}
			
			[Export ("setSize:", ArgumentSemantic.Copy)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetSize_, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetSize_, value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_Size_var = value;
			}
		}
		
		public virtual bool IsEmpty {
			[Export ("isEmpty")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsEmpty);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selIsEmpty);
				}
			}
			
		}
		
		protected override void Dispose (bool disposing)
		{
			__mt_TopLeft_var = null;
			__mt_Location_var = null;
			__mt_BottomRight_var = null;
			__mt_Size_var = null;
			base.Dispose (disposing);
		}
	} /* class SPRectangle */
}
