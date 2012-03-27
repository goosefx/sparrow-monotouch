using System;
using NUnit.Framework;
using MonoTouch.CoreGraphics;
using MonoTouch.UIKit;
using Sparrow;
using System.Drawing;

namespace UnitTests
{
	[TestFixture]
    public class SPTextureTests
	{
		[Test]
		public void DrawingDelegate()
		{
			bool draw = false;
			SPView view = new SPView(UIScreen.MainScreen.Bounds);
			
			SPTexture customTexture = new SPTexture(200.0f, 100.0f, delegate(CGContext context) {
				// draw a string
				context.SetFillColor(1.0f, 1.0f);
				string text = "Hello Core Graphics";
				// You need a UIView instance to properly draw a string with MonoTouch
				view.DrawString(text, new PointF(20.0f, 20.0f), 
	                                            UIFont.FromName("Arial", 25.0f));
				draw = true;
			});
			
			
			Assert.True(draw);
			
			//CGContext ctx;
		}
	}
}
