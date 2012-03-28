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
	[Register("SPDisplayObject", true)]
	public partial class SPDisplayObject : SPEventDispatcher {
		static IntPtr selX = Selector.GetHandle ("x");
		static IntPtr selSetX_ = Selector.GetHandle ("setX:");
		static IntPtr selY = Selector.GetHandle ("y");
		static IntPtr selSetY_ = Selector.GetHandle ("setY:");
		static IntPtr selPivotX = Selector.GetHandle ("pivotX");
		static IntPtr selSetPivotX_ = Selector.GetHandle ("setPivotX:");
		static IntPtr selPivotY = Selector.GetHandle ("pivotY");
		static IntPtr selSetPivotY_ = Selector.GetHandle ("setPivotY:");
		static IntPtr selScaleX = Selector.GetHandle ("scaleX");
		static IntPtr selSetScaleX_ = Selector.GetHandle ("setScaleX:");
		static IntPtr selScaleY = Selector.GetHandle ("scaleY");
		static IntPtr selSetScaleY_ = Selector.GetHandle ("setScaleY:");
		static IntPtr selWidth = Selector.GetHandle ("width");
		static IntPtr selSetWidth_ = Selector.GetHandle ("setWidth:");
		static IntPtr selHeight = Selector.GetHandle ("height");
		static IntPtr selSetHeight_ = Selector.GetHandle ("setHeight:");
		static IntPtr selRotation = Selector.GetHandle ("rotation");
		static IntPtr selSetRotation_ = Selector.GetHandle ("setRotation:");
		static IntPtr selAlpha = Selector.GetHandle ("alpha");
		static IntPtr selSetAlpha_ = Selector.GetHandle ("setAlpha:");
		static IntPtr selVisible = Selector.GetHandle ("visible");
		static IntPtr selSetVisible_ = Selector.GetHandle ("setVisible:");
		static IntPtr selTouchable = Selector.GetHandle ("touchable");
		static IntPtr selSetTouchable_ = Selector.GetHandle ("setTouchable:");
		static IntPtr selName = Selector.GetHandle ("name");
		static IntPtr selSetName_ = Selector.GetHandle ("setName:");
		static IntPtr selBounds = Selector.GetHandle ("bounds");
		static IntPtr selParent = Selector.GetHandle ("parent");
		static IntPtr selRoot = Selector.GetHandle ("root");
		static IntPtr selStage = Selector.GetHandle ("stage");
		static IntPtr selTransformationMatrix = Selector.GetHandle ("transformationMatrix");
		static IntPtr selRender_ = Selector.GetHandle ("render:");
		static IntPtr selRemoveFromParent = Selector.GetHandle ("removeFromParent");
		static IntPtr selTransformationMatrixToSpace_ = Selector.GetHandle ("transformationMatrixToSpace:");
		static IntPtr selBoundsInSpace_ = Selector.GetHandle ("boundsInSpace:");
		static IntPtr selLocalToGlobal_ = Selector.GetHandle ("localToGlobal:");
		static IntPtr selGlobalToLocal_ = Selector.GetHandle ("globalToLocal:");
		static IntPtr selHitTestPointForTouch_ = Selector.GetHandle ("hitTestPoint:forTouch:");
		static IntPtr selBroadcastEvent_ = Selector.GetHandle ("broadcastEvent:");
		
		static IntPtr class_ptr = Class.GetHandle ("SPDisplayObject");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[Export ("initWithCoder:")]
		public SPDisplayObject (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::Sparrow.Messaging.this_assembly;
			if (IsDirectBinding) {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.InitWithCoder, coder.Handle);
			} else {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.InitWithCoder, coder.Handle);
			}
		}

		public SPDisplayObject (NSObjectFlag t) : base (t) {}

		public SPDisplayObject (IntPtr handle) : base (handle) {}

		[Export ("render:")]
		public virtual void Render (SPRenderSupport support)
		{
			if (support == null)
				throw new ArgumentNullException ("support");
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selRender_, support.Handle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selRender_, support.Handle);
			}
		}
		
		[Export ("removeFromParent")]
		public virtual void RemoveFromParent ()
		{
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selRemoveFromParent);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper (this.SuperHandle, selRemoveFromParent);
			}
		}
		
		[Export ("transformationMatrixToSpace:")]
		public virtual SPMatrix TransformationMatrixToSpace (SPDisplayObject targetCoordinateSpace)
		{
			if (targetCoordinateSpace == null)
				throw new ArgumentNullException ("targetCoordinateSpace");
			if (IsDirectBinding) {
				return (SPMatrix) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, selTransformationMatrixToSpace_, targetCoordinateSpace.Handle));
			} else {
				return (SPMatrix) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, selTransformationMatrixToSpace_, targetCoordinateSpace.Handle));
			}
		}
		
		[Export ("boundsInSpace:")]
		public virtual SPRectangle BoundsInSpace (SPDisplayObject targetCoordinateSpace)
		{
			if (targetCoordinateSpace == null)
				throw new ArgumentNullException ("targetCoordinateSpace");
			if (IsDirectBinding) {
				return (SPRectangle) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, selBoundsInSpace_, targetCoordinateSpace.Handle));
			} else {
				return (SPRectangle) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, selBoundsInSpace_, targetCoordinateSpace.Handle));
			}
		}
		
		[Export ("localToGlobal:")]
		public virtual SPPoint LocalToGlobal (SPPoint localPoint)
		{
			if (localPoint == null)
				throw new ArgumentNullException ("localPoint");
			if (IsDirectBinding) {
				return (SPPoint) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, selLocalToGlobal_, localPoint.Handle));
			} else {
				return (SPPoint) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, selLocalToGlobal_, localPoint.Handle));
			}
		}
		
		[Export ("globalToLocal:")]
		public virtual SPPoint GlobalToLocal (SPPoint globalPoint)
		{
			if (globalPoint == null)
				throw new ArgumentNullException ("globalPoint");
			if (IsDirectBinding) {
				return (SPPoint) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, selGlobalToLocal_, globalPoint.Handle));
			} else {
				return (SPPoint) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, selGlobalToLocal_, globalPoint.Handle));
			}
		}
		
		[Export ("hitTestPoint:forTouch:")]
		public virtual SPDisplayObject HitTest (SPPoint localPoint, bool isTouch)
		{
			if (localPoint == null)
				throw new ArgumentNullException ("localPoint");
			if (IsDirectBinding) {
				return (SPDisplayObject) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_bool (this.Handle, selHitTestPointForTouch_, localPoint.Handle, isTouch));
			} else {
				return (SPDisplayObject) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr_bool (this.SuperHandle, selHitTestPointForTouch_, localPoint.Handle, isTouch));
			}
		}
		
		[Export ("broadcastEvent:")]
		public virtual void BroadcastEvent (SPEvent event_)
		{
			if (event_ == null)
				throw new ArgumentNullException ("event_");
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selBroadcastEvent_, event_.Handle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selBroadcastEvent_, event_.Handle);
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
		
		public virtual float PivotX {
			[Export ("pivotX", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selPivotX);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSendSuper (this.SuperHandle, selPivotX);
				}
			}
			
			[Export ("setPivotX:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, selSetPivotX_, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_float (this.SuperHandle, selSetPivotX_, value);
				}
			}
		}
		
		public virtual float PivotY {
			[Export ("pivotY", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selPivotY);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSendSuper (this.SuperHandle, selPivotY);
				}
			}
			
			[Export ("setPivotY:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, selSetPivotY_, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_float (this.SuperHandle, selSetPivotY_, value);
				}
			}
		}
		
		public virtual float ScaleX {
			[Export ("scaleX", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selScaleX);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSendSuper (this.SuperHandle, selScaleX);
				}
			}
			
			[Export ("setScaleX:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, selSetScaleX_, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_float (this.SuperHandle, selSetScaleX_, value);
				}
			}
		}
		
		public virtual float ScaleY {
			[Export ("scaleY", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selScaleY);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSendSuper (this.SuperHandle, selScaleY);
				}
			}
			
			[Export ("setScaleY:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, selSetScaleY_, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_float (this.SuperHandle, selSetScaleY_, value);
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
		
		public virtual float Rotation {
			[Export ("rotation", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selRotation);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSendSuper (this.SuperHandle, selRotation);
				}
			}
			
			[Export ("setRotation:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, selSetRotation_, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_float (this.SuperHandle, selSetRotation_, value);
				}
			}
		}
		
		public virtual float Alpha {
			[Export ("alpha", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selAlpha);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSendSuper (this.SuperHandle, selAlpha);
				}
			}
			
			[Export ("setAlpha:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, selSetAlpha_, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_float (this.SuperHandle, selSetAlpha_, value);
				}
			}
		}
		
		public virtual bool Visible {
			[Export ("visible", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selVisible);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selVisible);
				}
			}
			
			[Export ("setVisible:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetVisible_, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetVisible_, value);
				}
			}
		}
		
		public virtual bool Touchable {
			[Export ("touchable", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selTouchable);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selTouchable);
				}
			}
			
			[Export ("setTouchable:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetTouchable_, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetTouchable_, value);
				}
			}
		}
		
		public virtual string Name {
			[Export ("name", ArgumentSemantic.Copy)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selName));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selName));
				}
			}
			
			[Export ("setName:", ArgumentSemantic.Copy)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = new NSString (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetName_, nsvalue.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetName_, nsvalue.Handle);
				}
				nsvalue.Dispose ();
				
			}
		}
		
		object __mt_Bounds_var;
		public virtual SPRectangle Bounds {
			[Export ("bounds")]
			get {
				SPRectangle ret;
				if (IsDirectBinding) {
					ret = (SPRectangle) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selBounds));
				} else {
					ret = (SPRectangle) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selBounds));
				}
				MarkDirty ();
				__mt_Bounds_var = ret;
				return ret;
			}
			
		}
		
		object __mt_Parent_var;
		public virtual SPDisplayObjectContainer Parent {
			[Export ("parent")]
			get {
				SPDisplayObjectContainer ret;
				if (IsDirectBinding) {
					ret = (SPDisplayObjectContainer) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selParent));
				} else {
					ret = (SPDisplayObjectContainer) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selParent));
				}
				MarkDirty ();
				__mt_Parent_var = ret;
				return ret;
			}
			
		}
		
		object __mt_Root_var;
		public virtual SPDisplayObject Root {
			[Export ("root")]
			get {
				SPDisplayObject ret;
				if (IsDirectBinding) {
					ret = (SPDisplayObject) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selRoot));
				} else {
					ret = (SPDisplayObject) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selRoot));
				}
				MarkDirty ();
				__mt_Root_var = ret;
				return ret;
			}
			
		}
		
		object __mt_Stage_var;
		public virtual SPStage Stage {
			[Export ("stage")]
			get {
				SPStage ret;
				if (IsDirectBinding) {
					ret = (SPStage) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selStage));
				} else {
					ret = (SPStage) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selStage));
				}
				MarkDirty ();
				__mt_Stage_var = ret;
				return ret;
			}
			
		}
		
		object __mt_TransformationMatrix_var;
		public virtual SPMatrix TransformationMatrix {
			[Export ("transformationMatrix")]
			get {
				SPMatrix ret;
				if (IsDirectBinding) {
					ret = (SPMatrix) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selTransformationMatrix));
				} else {
					ret = (SPMatrix) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selTransformationMatrix));
				}
				MarkDirty ();
				__mt_TransformationMatrix_var = ret;
				return ret;
			}
			
		}
		
		protected override void Dispose (bool disposing)
		{
			__mt_Bounds_var = null;
			__mt_Parent_var = null;
			__mt_Root_var = null;
			__mt_Stage_var = null;
			__mt_TransformationMatrix_var = null;
			base.Dispose (disposing);
		}
	} /* class SPDisplayObject */
}
