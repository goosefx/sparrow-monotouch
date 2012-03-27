using System;
using MonoTouch.CoreGraphics;

namespace Sparrow
{
	public delegate void SPTextureDrawingDelegate(CGContext context);
	
	public partial class SPTexture
	{
		private static _SPTextureDrawingDelegate InternalDrawingDelegate(SPTextureDrawingDelegate drawingDelegate)
		{
			// TODO: check for memory leaks
			return delegate(IntPtr contextHandle) {
				
				CGContext context = new CGContext(contextHandle);
				drawingDelegate(context);
				context.Dispose(); // TODO: is dispose here ok?
				context = null;
			};
		}
	
		public SPTexture(float width, float height, SPTextureDrawingDelegate drawingDelegate) :
			this(width, height, InternalDrawingDelegate(drawingDelegate))
		{
			
		}

		public SPTexture(float width, float height, float scale, SPColorSpace colorSpace, SPTextureDrawingDelegate drawingDelegate) :
				this(width, height, scale, colorSpace, InternalDrawingDelegate(drawingDelegate))
		{
			
		}
		
	}
}

