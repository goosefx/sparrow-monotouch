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
	[Register("SPDisplayObjectContainer", true)]
	public partial class SPDisplayObjectContainer : SPDisplayObject {
		static IntPtr selNumChildren = Selector.GetHandle ("numChildren");
		static IntPtr selAddChild_ = Selector.GetHandle ("addChild:");
		static IntPtr selAddChildAtIndex_ = Selector.GetHandle ("addChild:atIndex:");
		static IntPtr selContainsChild_ = Selector.GetHandle ("containsChild:");
		static IntPtr selChildAtIndex_ = Selector.GetHandle ("childAtIndex:");
		static IntPtr selChildByName_ = Selector.GetHandle ("childByName:");
		static IntPtr selChildIndex_ = Selector.GetHandle ("childIndex:");
		static IntPtr selSetIndexOfChild_ = Selector.GetHandle ("setIndex:ofChild:");
		static IntPtr selRemoveChild_ = Selector.GetHandle ("removeChild:");
		static IntPtr selRemoveChildAtIndex_ = Selector.GetHandle ("removeChildAtIndex:");
		static IntPtr selRemoveAllChildren = Selector.GetHandle ("removeAllChildren");
		static IntPtr selSwapChildWithChild_ = Selector.GetHandle ("swapChild:withChild:");
		static IntPtr selSwapChildAtIndexWithChildAtIndex_ = Selector.GetHandle ("swapChildAtIndex:withChildAtIndex:");
		static IntPtr selSortChildren_ = Selector.GetHandle ("sortChildren:");
		
		static IntPtr class_ptr = Class.GetHandle ("SPDisplayObjectContainer");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[Export ("initWithCoder:")]
		public SPDisplayObjectContainer (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::Sparrow.Messaging.this_assembly;
			if (IsDirectBinding) {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.InitWithCoder, coder.Handle);
			} else {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.InitWithCoder, coder.Handle);
			}
		}

		public SPDisplayObjectContainer (NSObjectFlag t) : base (t) {}

		public SPDisplayObjectContainer (IntPtr handle) : base (handle) {}

		[Export ("addChild:")]
		public virtual void Add (SPDisplayObject child)
		{
			if (child == null)
				throw new ArgumentNullException ("child");
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selAddChild_, child.Handle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selAddChild_, child.Handle);
			}
		}
		
		[Export ("addChild:atIndex:")]
		internal virtual void _AddAtIndex (SPDisplayObject child, int index)
		{
			if (child == null)
				throw new ArgumentNullException ("child");
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_int (this.Handle, selAddChildAtIndex_, child.Handle, index);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_int (this.SuperHandle, selAddChildAtIndex_, child.Handle, index);
			}
		}
		
		[Export ("containsChild:")]
		public virtual bool Contains (SPDisplayObject child)
		{
			if (child == null)
				throw new ArgumentNullException ("child");
			if (IsDirectBinding) {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend_IntPtr (this.Handle, selContainsChild_, child.Handle);
			} else {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper_IntPtr (this.SuperHandle, selContainsChild_, child.Handle);
			}
		}
		
		[Export ("childAtIndex:")]
		internal virtual SPDisplayObject _ChildAtIndex (int index)
		{
			if (IsDirectBinding) {
				return (SPDisplayObject) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_int (this.Handle, selChildAtIndex_, index));
			} else {
				return (SPDisplayObject) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_int (this.SuperHandle, selChildAtIndex_, index));
			}
		}
		
		[Export ("childByName:")]
		internal virtual SPDisplayObject _ChildByName (string name)
		{
			if (name == null)
				throw new ArgumentNullException ("name");
			var nsname = new NSString (name);
			
			SPDisplayObject ret;
			if (IsDirectBinding) {
				ret = (SPDisplayObject) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, selChildByName_, nsname.Handle));
			} else {
				ret = (SPDisplayObject) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, selChildByName_, nsname.Handle));
			}
			nsname.Dispose ();
			
			return ret;
		}
		
		[Export ("childIndex:")]
		public virtual int IndexOf (SPDisplayObject child)
		{
			if (child == null)
				throw new ArgumentNullException ("child");
			if (IsDirectBinding) {
				return MonoTouch.ObjCRuntime.Messaging.int_objc_msgSend_IntPtr (this.Handle, selChildIndex_, child.Handle);
			} else {
				return MonoTouch.ObjCRuntime.Messaging.int_objc_msgSendSuper_IntPtr (this.SuperHandle, selChildIndex_, child.Handle);
			}
		}
		
		[Export ("setIndex:ofChild:")]
		public virtual void Move (int index, SPDisplayObject child)
		{
			if (child == null)
				throw new ArgumentNullException ("child");
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_int_IntPtr (this.Handle, selSetIndexOfChild_, index, child.Handle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_int_IntPtr (this.SuperHandle, selSetIndexOfChild_, index, child.Handle);
			}
		}
		
		[Export ("removeChild:")]
		internal virtual void _Remove (SPDisplayObject child)
		{
			if (child == null)
				throw new ArgumentNullException ("child");
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selRemoveChild_, child.Handle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selRemoveChild_, child.Handle);
			}
		}
		
		[Export ("removeChildAtIndex:")]
		public virtual void RemoveAt (int index)
		{
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_int (this.Handle, selRemoveChildAtIndex_, index);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, selRemoveChildAtIndex_, index);
			}
		}
		
		[Export ("removeAllChildren")]
		public virtual void Clear ()
		{
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selRemoveAllChildren);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper (this.SuperHandle, selRemoveAllChildren);
			}
		}
		
		[Export ("swapChild:withChild:")]
		public virtual void Swap (SPDisplayObject child1, SPDisplayObject child2)
		{
			if (child1 == null)
				throw new ArgumentNullException ("child1");
			if (child2 == null)
				throw new ArgumentNullException ("child2");
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, selSwapChildWithChild_, child1.Handle, child2.Handle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, selSwapChildWithChild_, child1.Handle, child2.Handle);
			}
		}
		
		[Export ("swapChildAtIndex:withChildAtIndex:")]
		public virtual void Swap (int index1, int index2)
		{
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_int_int (this.Handle, selSwapChildAtIndexWithChildAtIndex_, index1, index2);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_int_int (this.SuperHandle, selSwapChildAtIndexWithChildAtIndex_, index1, index2);
			}
		}
		
		[Export ("sortChildren:")]
		public unsafe virtual void Sort (SPDisplayObjectComparator comparator)
		{
			if (comparator == null)
				throw new ArgumentNullException ("comparator");
			BlockLiteral *block_ptr_comparator;
			BlockLiteral block_comparator;
			block_comparator = new BlockLiteral ();
			block_ptr_comparator = &block_comparator;
			block_comparator.SetupBlock (static_InnerSPDisplayObjectComparator, comparator);
			
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSortChildren_, (IntPtr) block_ptr_comparator);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSortChildren_, (IntPtr) block_ptr_comparator);
			}
			block_ptr_comparator->CleanupBlock ();
			
		}
		
		public virtual int Count {
			[Export ("numChildren")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.int_objc_msgSend (this.Handle, selNumChildren);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.int_objc_msgSendSuper (this.SuperHandle, selNumChildren);
				}
			}
			
		}
		
		internal delegate void InnerSPDisplayObjectComparator (IntPtr block, IntPtr obj1, IntPtr obj2);
		static InnerSPDisplayObjectComparator static_InnerSPDisplayObjectComparator = new InnerSPDisplayObjectComparator (TrampolineSPDisplayObjectComparator);
		[MonoPInvokeCallback (typeof (InnerSPDisplayObjectComparator))]
		static unsafe void TrampolineSPDisplayObjectComparator (IntPtr block, IntPtr obj1, IntPtr obj2) {
			var descriptor = (BlockLiteral *) block;
			var del = (Sparrow.SPDisplayObjectComparator) (descriptor->global_handle != IntPtr.Zero ? GCHandle.FromIntPtr (descriptor->global_handle).Target : GCHandle.FromIntPtr (descriptor->local_handle).Target);
			del ((Sparrow.SPDisplayObject) Runtime.GetNSObject (obj1), (Sparrow.SPDisplayObject) Runtime.GetNSObject (obj2));
		}
		
	} /* class SPDisplayObjectContainer */
	public delegate int SPDisplayObjectComparator (SPDisplayObject obj1, SPDisplayObject obj2);
}
