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
	[Register("SPTextField", true)]
	public partial class SPTextField : SPDisplayObjectContainer {
		static IntPtr selText = Selector.GetHandle ("text");
		static IntPtr selSetText_ = Selector.GetHandle ("setText:");
		static IntPtr selFontName = Selector.GetHandle ("fontName");
		static IntPtr selSetFontName_ = Selector.GetHandle ("setFontName:");
		static IntPtr selFontSize = Selector.GetHandle ("fontSize");
		static IntPtr selSetFontSize_ = Selector.GetHandle ("setFontSize:");
		static IntPtr selHAlign = Selector.GetHandle ("hAlign");
		static IntPtr selSetHAlign_ = Selector.GetHandle ("setHAlign:");
		static IntPtr selVAlign = Selector.GetHandle ("vAlign");
		static IntPtr selSetVAlign_ = Selector.GetHandle ("setVAlign:");
		static IntPtr selBorder = Selector.GetHandle ("border");
		static IntPtr selSetBorder_ = Selector.GetHandle ("setBorder:");
		static IntPtr selColor = Selector.GetHandle ("color");
		static IntPtr selSetColor_ = Selector.GetHandle ("setColor:");
		static IntPtr selTextBounds = Selector.GetHandle ("textBounds");
		static IntPtr selKerning = Selector.GetHandle ("kerning");
		static IntPtr selSetKerning_ = Selector.GetHandle ("setKerning:");
		static IntPtr selRegisterBitmapFontFromFileTexture_ = Selector.GetHandle ("registerBitmapFontFromFile:texture:");
		static IntPtr selRegisterBitmapFontFromFile_ = Selector.GetHandle ("registerBitmapFontFromFile:");
		static IntPtr selUnregisterBitmapFont_ = Selector.GetHandle ("unregisterBitmapFont:");
		static IntPtr selInitWithWidthHeightTextFontNameFontSizeColor_ = Selector.GetHandle ("initWithWidth:height:text:fontName:fontSize:color:");
		static IntPtr selInitWithWidthHeightText_ = Selector.GetHandle ("initWithWidth:height:text:");
		static IntPtr selInitWithText_ = Selector.GetHandle ("initWithText:");
		
		static IntPtr class_ptr = Class.GetHandle ("SPTextField");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[Export ("initWithCoder:")]
		public SPTextField (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::Sparrow.Messaging.this_assembly;
			if (IsDirectBinding) {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.InitWithCoder, coder.Handle);
			} else {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.InitWithCoder, coder.Handle);
			}
		}

		public SPTextField (NSObjectFlag t) : base (t) {}

		public SPTextField (IntPtr handle) : base (handle) {}

		[Export ("registerBitmapFontFromFile:texture:")]
		public static string RegisterBitmapFont (string path, SPTexture texture)
		{
			if (path == null)
				throw new ArgumentNullException ("path");
			if (texture == null)
				throw new ArgumentNullException ("texture");
			var nspath = new NSString (path);
			
			string ret;
			ret = NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (class_ptr, selRegisterBitmapFontFromFileTexture_, nspath.Handle, texture.Handle));
			nspath.Dispose ();
			
			return ret;
		}
		
		[Export ("registerBitmapFontFromFile:")]
		public static string RegisterBitmapFont (string path)
		{
			if (path == null)
				throw new ArgumentNullException ("path");
			var nspath = new NSString (path);
			
			string ret;
			ret = NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (class_ptr, selRegisterBitmapFontFromFile_, nspath.Handle));
			nspath.Dispose ();
			
			return ret;
		}
		
		[Export ("unregisterBitmapFont:")]
		public static void UnregisterBitmapFont (string name)
		{
			if (name == null)
				throw new ArgumentNullException ("name");
			var nsname = new NSString (name);
			
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (class_ptr, selUnregisterBitmapFont_, nsname.Handle);
			nsname.Dispose ();
			
		}
		
		[Export ("initWithWidth:height:text:fontName:fontSize:color:")]
		public SPTextField (float width, float height, string text, string fontName, float size, System.UInt32 color) : base (NSObjectFlag.Empty)
		{
			if (text == null)
				throw new ArgumentNullException ("text");
			if (fontName == null)
				throw new ArgumentNullException ("fontName");
			var nstext = new NSString (text);
			var nsfontName = new NSString (fontName);
			
			IsDirectBinding = GetType ().Assembly == global::Sparrow.Messaging.this_assembly;
			if (IsDirectBinding) {
				Handle = Sparrow.Messaging.IntPtr_objc_msgSend_float_float_IntPtr_IntPtr_float_UInt32 (this.Handle, selInitWithWidthHeightTextFontNameFontSizeColor_, width, height, nstext.Handle, nsfontName.Handle, size, color);
			} else {
				Handle = Sparrow.Messaging.IntPtr_objc_msgSendSuper_float_float_IntPtr_IntPtr_float_UInt32 (this.SuperHandle, selInitWithWidthHeightTextFontNameFontSizeColor_, width, height, nstext.Handle, nsfontName.Handle, size, color);
			}
			nstext.Dispose ();
			nsfontName.Dispose ();
			
		}
		
		[Export ("initWithWidth:height:text:")]
		public SPTextField (float width, float height, string text) : base (NSObjectFlag.Empty)
		{
			if (text == null)
				throw new ArgumentNullException ("text");
			var nstext = new NSString (text);
			
			IsDirectBinding = GetType ().Assembly == global::Sparrow.Messaging.this_assembly;
			if (IsDirectBinding) {
				Handle = Sparrow.Messaging.IntPtr_objc_msgSend_float_float_IntPtr (this.Handle, selInitWithWidthHeightText_, width, height, nstext.Handle);
			} else {
				Handle = Sparrow.Messaging.IntPtr_objc_msgSendSuper_float_float_IntPtr (this.SuperHandle, selInitWithWidthHeightText_, width, height, nstext.Handle);
			}
			nstext.Dispose ();
			
		}
		
		[Export ("initWithText:")]
		public SPTextField (string text) : base (NSObjectFlag.Empty)
		{
			if (text == null)
				throw new ArgumentNullException ("text");
			var nstext = new NSString (text);
			
			IsDirectBinding = GetType ().Assembly == global::Sparrow.Messaging.this_assembly;
			if (IsDirectBinding) {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, selInitWithText_, nstext.Handle);
			} else {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, selInitWithText_, nstext.Handle);
			}
			nstext.Dispose ();
			
		}
		
		public virtual string Text {
			[Export ("text", ArgumentSemantic.Copy)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selText));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selText));
				}
			}
			
			[Export ("setText:", ArgumentSemantic.Copy)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = new NSString (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetText_, nsvalue.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetText_, nsvalue.Handle);
				}
				nsvalue.Dispose ();
				
			}
		}
		
		public virtual string FontName {
			[Export ("fontName", ArgumentSemantic.Copy)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selFontName));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selFontName));
				}
			}
			
			[Export ("setFontName:", ArgumentSemantic.Copy)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = new NSString (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetFontName_, nsvalue.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetFontName_, nsvalue.Handle);
				}
				nsvalue.Dispose ();
				
			}
		}
		
		public virtual float FontSize {
			[Export ("fontSize", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selFontSize);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSendSuper (this.SuperHandle, selFontSize);
				}
			}
			
			[Export ("setFontSize:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, selSetFontSize_, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_float (this.SuperHandle, selSetFontSize_, value);
				}
			}
		}
		
		public virtual SPHorizontalAlignment HorizontalAlignment {
			[Export ("hAlign", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return (SPHorizontalAlignment) MonoTouch.ObjCRuntime.Messaging.int_objc_msgSend (this.Handle, selHAlign);
				} else {
					return (SPHorizontalAlignment) MonoTouch.ObjCRuntime.Messaging.int_objc_msgSendSuper (this.SuperHandle, selHAlign);
				}
			}
			
			[Export ("setHAlign:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_int (this.Handle, selSetHAlign_, (int)value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, selSetHAlign_, (int)value);
				}
			}
		}
		
		public virtual SPVerticalAlignment VerticalAlignment {
			[Export ("vAlign", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return (SPVerticalAlignment) MonoTouch.ObjCRuntime.Messaging.int_objc_msgSend (this.Handle, selVAlign);
				} else {
					return (SPVerticalAlignment) MonoTouch.ObjCRuntime.Messaging.int_objc_msgSendSuper (this.SuperHandle, selVAlign);
				}
			}
			
			[Export ("setVAlign:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_int (this.Handle, selSetVAlign_, (int)value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, selSetVAlign_, (int)value);
				}
			}
		}
		
		public virtual bool Border {
			[Export ("border", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selBorder);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selBorder);
				}
			}
			
			[Export ("setBorder:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetBorder_, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetBorder_, value);
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
		
		object __mt_TextBounds_var;
		public virtual SPRectangle TextBounds {
			[Export ("textBounds")]
			get {
				SPRectangle ret;
				if (IsDirectBinding) {
					ret = (SPRectangle) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selTextBounds));
				} else {
					ret = (SPRectangle) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selTextBounds));
				}
				MarkDirty ();
				__mt_TextBounds_var = ret;
				return ret;
			}
			
		}
		
		public virtual bool Kerning {
			[Export ("kerning", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selKerning);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selKerning);
				}
			}
			
			[Export ("setKerning:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetKerning_, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetKerning_, value);
				}
			}
		}
		
		protected override void Dispose (bool disposing)
		{
			__mt_TextBounds_var = null;
			base.Dispose (disposing);
		}
	} /* class SPTextField */
}
