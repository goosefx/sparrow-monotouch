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
		public void Constructors()
		{
			bool draw1 = false;
			bool draw2 = false;
			SPView view = new SPView(UIScreen.MainScreen.Bounds);
			
			SPTexture t1 = new SPTexture(200.0f, 100.0f, delegate(CGContext context) {
				// draw a string
				context.SetFillColor(1.0f, 1.0f);
				string text = "Hello Core Graphics";
				// You need a UIView instance to properly draw a string with MonoTouch
				view.DrawString(text, new PointF(20.0f, 20.0f), 
	                                            UIFont.FromName("Arial", 25.0f));
				draw1 = true;
			});
			
			SPTexture t2 = new SPTexture(200.0f, 100.0f, 2.0f, SPColorSpace.RGBA, delegate(CGContext context) {
				// draw a string
				context.SetFillColor(1.0f, 1.0f);
				string text = "Hello Core Graphics";
				// You need a UIView instance to properly draw a string with MonoTouch
				view.DrawString(text, new PointF(20.0f, 20.0f), 
	                                            UIFont.FromName("Arial", 25.0f));
				draw2 = true;
			});
			
			SPTexture t3 = new SPTexture("Media/logo.png");
			SPTexture t4 = new SPTexture(UIImage.FromBundle("Media/logo.png"));
			SPTexture t5 = new SPTexture(new SPRectangle(10.0f, 10.0f, 300.0f, 90.0f), t4);
			SPTexture t6 = SPTexture.EmptyTexture();
			
			Assert.True(t1.Handle != IntPtr.Zero);
			Assert.True(t2.Handle != IntPtr.Zero);
			Assert.True(t3.Handle != IntPtr.Zero);
			Assert.True(t4.Handle != IntPtr.Zero);
			Assert.True(t5.Handle != IntPtr.Zero);
			Assert.True(t6.Handle != IntPtr.Zero);
			Assert.True(draw1);
			Assert.True(draw2);
		}

		[Test]
		public void Properties()
		{
			SPTexture t1 = new SPTexture("Media/logo.png");
			
			Assert.True(t1.Width == 320.0f);
			Assert.True(t1.Height == 112.0f);
			Assert.True(t1.TextureID > 0);
			Assert.True(t1.Scale >= 1.0f);
			Assert.True(t1.Frame == null);
			Assert.False(t1.Repeat);
			Assert.True(t1.Filter == SPTextureFilter.Bilinear);
			Assert.True(t1.HasPremultipliedAlpha);
		}
		
		[Test]
		[Ignore("TODO")]
		public void AdjustTextureCoordinates()
		{
			
		}
		
	}
}
