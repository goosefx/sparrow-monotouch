using System;
using System.Drawing;
using NUnit.Framework;
using Sparrow;

namespace UnitTests
{
	[TestFixture]
    public class SPRectangleTests
	{
		[Test]
		public void Everything()
		{
			SPRectangle r1 = new SPRectangle(5.0f, 10.0f, 100.0f, 20.0f);
			SPRectangle r2 = new SPRectangle(new SPPoint(5.0f, 10.0f), 100.0f, 20.0f);
			SPRectangle r3 = new SPRectangle(new SPPoint(5.0f, 10.0f), new SPPoint(105.0f, 30.0f));
			SPRectangle r4 = SPRectangle.FromLTRB(10.0f, 20.0f, 60.0f, 40.0f);
			SPRectangle r5 = new SPRectangle(0.0f, 200.0f, 100.0f, 20.0f);
			SPRectangle r6 = r1.Intersect(r4);
			SPRectangle r7 = r1.Union(r4);
			SPRectangle r8 = r4.Inflate(10.0f, 5.0f);
			SPRectangle r9 = r4.Inflate(new SPPoint(10.0f, 5.0f));
			SPRectangle r10 = r1.Clone();
			SPRectangle r11 = r10.Clone();
			RectangleF r12 = r3;
			SPRectangle r13 = r12;
			SPRectangle r14 = r1.Clone();
			SPRectangle r15 = r1 + r4;
			
			r14.SetEmpty();
			r10.Offset(5.0f, 20.0f);
			r11.Offset(new SPPoint(10.0f, 30.0f));
			
			Assert.True(r1.X == 5.0f);
			Assert.True(r1.Left == r1.X);
			Assert.True(r1.Y == 10.0f);
			Assert.True(r1.Top == r1.Y);
			Assert.True(r1.Right == 105.0f);
			Assert.True(r1.Bottom == 30.0f);
			Assert.True(r1.TopLeft == new SPPoint(5.0f, 10.0f));
			Assert.True(r1.TopLeft == r1.Location);
			Assert.True(r1.Center == new SPPoint(55.0f, 20.0f));
			Assert.True(r1.BottomRight == new SPPoint(105.0f, 30.0f));
			Assert.True(r4.Width == 50.0f);
			Assert.True(r4.Height == 20.0f);
			Assert.True(r4.Size == new SPPoint(50.0f, 20.0f));
			Assert.True(r6.X == 10.0f);
			Assert.True(r6.Y == 20.0f);
			Assert.True(r6.Width == 50.0f);
			Assert.True(r6.Height == 10.0f);
			Assert.True(r7.X == 5.0f);
			Assert.True(r7.Y == 10.0f);
			Assert.True(r7.Width == 100.0f);
			Assert.True(r7.Height == 30.0f);
			Assert.True(r8.X == 0.0f);
			Assert.True(r8.Y == 15.0f);
			Assert.True(r8.Width == 70.0f);
			Assert.True(r8.Height == 30.0f);
			Assert.True(r10.X == 10.0f);
			Assert.True(r10.Y == 30.0f);
			Assert.True(r11.X == 15.0f);
			Assert.True(r11.Y == 40.0f);
			Assert.False(r1.IsEmpty);
			Assert.True(r14.IsEmpty);
			Assert.True(r1.IntersectsWith(r4));
			Assert.False(r1.IntersectsWith(r5));
			
			Assert.True(r1 == r2);
			Assert.True(r1 == r3);
			Assert.True(r3 == r2);
			Assert.True(r3 == r13);
			Assert.True(r7 == r15);
			Assert.True(r8 == r9);
			Assert.False(r1 == r4);
		}

	}
}
