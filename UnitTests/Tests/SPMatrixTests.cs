using System;
using System.Drawing;
using NUnit.Framework;
using Sparrow;

namespace UnitTests
{
	[TestFixture]
    public class SPMatrixTests
	{
		[Test]
		public void Everything()
		{
			SPMatrix m1 = new SPMatrix(1.0f, 2.0f, 3.0f, 4.0f, 5.0f, 6.0f);
			SPMatrix m2 = new SPMatrix();
			SPMatrix m3 = new SPMatrix();
			SPMatrix m4 = m1.Clone();
			SPMatrix m5 = m1.Clone();
			SPMatrix m6 = m1.Clone();
			SPPoint p1 = new SPPoint(5.0f, 10.0f);
			SPPoint p2 = m1.Transform(p1);
			
			m3.Set(1.0f, 2.0f, 3.0f, 4.0f, 5.0f, 6.0f);
			m5.SetIdentity();
			m6.Rotate(20.0f);
			m6.Scale(10.0f);
			m6.Scale(1.5f, 2.0f);
			m6.Translate(5.0f, 3.0f);
			m6.Invert();
			m6.Concat(m1);
			
			Assert.True(m1.A == 1.0f);
			Assert.True(m1.B == 2.0f);
			Assert.True(m1.C == 3.0f);
			Assert.True(m1.D == 4.0f);
			Assert.True(m1.Tx == 5.0f);
			Assert.True(m1.Ty == 6.0f);
			Assert.True(m1.Determinant != 0.0f);
			
			Assert.False(m1 == m2);
			Assert.True(m1 != m2);
			Assert.True(m1 == m3);
			Assert.False(m1 != m3);
			Assert.True(m1 == m4);
			Assert.True(m2 == m5);
			Assert.False(p1 == p2);
		}
	}
}
