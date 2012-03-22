using System;
using NUnit.Framework;
using Sparrow;

namespace UnitTests
{
	[TestFixture]
    public class SPQuadTests
	{
		[Test]
		public void Constructors()
		{
			SPQuad q1 = new SPQuad();
			SPQuad q2 = new SPQuad(16.0f, 36.0f);
			SPQuad q3 = new SPQuad(32.0f, 48.0f, SPColor.Red);
			
			Assert.True(q1.Width == q1.Height);
			Assert.True(q1.Width == 32.0f);
			Assert.True(q2.Width == 16.0f);
			Assert.True(q2.Height == 36.0f);
			Assert.True(q3.Width == 32.0f);
			Assert.True(q3.Height == 48.0f);
			Assert.True(q3.Color == SPColor.Red);
		}

		[Test]
		public void Colors()
		{
			SPQuad q1 = new SPQuad();
			
			q1.SetColor(SPColor.Red, 0);
			q1.SetColor(SPColor.Green, 1);
			q1.SetColor(SPColor.Blue, 2);
			q1.SetColor(SPColor.White, 3);
			
			Assert.True(q1.Color == SPColor.Red);
			Assert.True(q1.GetColor(0) == SPColor.Red);
			Assert.True(q1.GetColor(1) == SPColor.Green);
			Assert.True(q1.GetColor(2) == SPColor.Blue);
			Assert.True(q1.GetColor(3) == SPColor.White);
			
			q1.Color = SPColor.Gray;
			Assert.True(q1.GetColor(0) == SPColor.Gray);
			Assert.True(q1.GetColor(1) == SPColor.Gray);
			Assert.True(q1.GetColor(2) == SPColor.Gray);
			Assert.True(q1.GetColor(3) == SPColor.Gray);
		}	
	}
}
