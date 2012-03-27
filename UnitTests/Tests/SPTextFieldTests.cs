using System;
using NUnit.Framework;
using Sparrow;

namespace UnitTests
{
	[TestFixture]
    public class SPTextFieldTests
	{
		[Test]
		public void Constructors()
		{
			#region ...
			SPTextField t1 = new SPTextField(200.0f, 100.0f, "Hello World!", "Arial", 30.0f, SPColor.Red);
			SPTextField t2 = new SPTextField(140.0f, 50.0f, "Hello");
			SPTextField t3 = new SPTextField("World");
			
			Assert.True(t1.Handle != IntPtr.Zero);
			Assert.True(t2.Handle != IntPtr.Zero);
			Assert.True(t3.Handle != IntPtr.Zero);
			#endregion
		}
		
		[Test]
		public void RegisterBitmapFont()
		{
			#region ...
			
			string fontName = SPTextField.RegisterBitmapFont("Media/desyrel.fnt");
			
			Assert.True(fontName == "Desyrel");
			
			SPTextField t1 = new SPTextField(200.0f, 100.0f, "Hello World!", fontName, SPTextField.NativeFontSize, SPTextField.DefaultFontColor);
			
			Assert.True(t1.FontName == fontName);
			
			t1.Dispose();
			SPTextField.UnregisterBitmapFont(fontName);
			
			#endregion			
		}

		[Test]
		[Ignore("SPTexture not implemented!")]
		public void RegisterBitmapFontWithTexture()
		{
			#region ...
			
			#endregion			
		}

		[Test]
		public void Properties()
		{
			#region ...
			
			SPTextField tf = new SPTextField("World");
			tf.Text = "Hello " + tf.Text + "!";
			tf.FontName = "Arial";
			tf.FontSize = 30.0f;
			tf.HorizontalAlignment = SPHorizontalAlignment.Right;
			tf.VerticalAlignment = SPVerticalAlignment.Bottom;
			tf.Border = true;
			tf.Color = SPColor.Fuchsia;
			tf.Kerning = false;
			SPRectangle tb = tf.TextBounds;
			
			Assert.True(tf.Text == "Hello World!");
			Assert.True(tf.FontName == "Arial");
			Assert.True(tf.FontSize == 30.0f);
			Assert.True(tf.HorizontalAlignment == SPHorizontalAlignment.Right);
			Assert.True(tf.VerticalAlignment == SPVerticalAlignment.Bottom);
			Assert.True(tf.Border);
			Assert.True(tf.Color == SPColor.Fuchsia);
			Assert.False(tf.Kerning);
			Assert.False(tb.IsEmpty);
			
			#endregion		
		}
	}
}
