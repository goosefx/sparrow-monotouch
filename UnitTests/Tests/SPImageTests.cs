using System;
using NUnit.Framework;
using MonoTouch.CoreGraphics;
using MonoTouch.UIKit;
using Sparrow;
using System.Drawing;

namespace UnitTests
{
	[TestFixture]
    public class SPImageTests
	{
		[Test]
		public void Everything()
		{
			SPTexture t1 = new SPTexture("Media/logo.png");
			
			SPImage i1 = new SPImage(t1);
			SPImage i2 = new SPImage("Media/logo.png");
			
			i2.SetTexCoords(new SPPoint(0.5f, 0.2f), 0);
			i2.SetTexCoords(new SPPoint(0.9f, 1.0f), 3);
			
			Assert.True(i1.Handle != IntPtr.Zero);
			Assert.True(i2.Handle != IntPtr.Zero);
			Assert.True(i1.Texture == t1);
			Assert.True(i2.GetTexCoords(0) == new SPPoint(0.5f, 0.2f));
		}
	}
}
