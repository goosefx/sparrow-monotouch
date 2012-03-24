using System;
using System.Drawing;
using NUnit.Framework;
using Sparrow;

namespace UnitTests
{
	[TestFixture]
    public class SPPointTests
	{
		[Test]
		public void Everything()
		{
			#region ...
			
			SPPoint p1 = new SPPoint(0.0f, 0.0f);
			SPPoint p2 = new SPPoint(8.0f, 16.0f);
			SPPoint p3 = p2.Scale(0.5f);
			SPPoint p4 = p3.Rotate(-1.570796327f);
			SPPoint p5 = p3.Normalize();
			SPPoint p6 = p3.Invert();
			SPPoint p7 = SPPoint.WithPolarLength(p2.Length, p2.Angle);
			SPPoint p8 = SPPoint.Interpolate(p1, p2, 0.5f);
			SPPoint p9 = p2 + p3;
			SPPoint p10 = p1 - p2;
			SPPoint p11 = p2 * 0.5f;
			float f1 = SPPoint.CalculateDistance(p1, p2);
			float f2 = SPPoint.CalculateAngle(p2, p4);
			float f3 = p2.Dot(p4); // ???
			PointF p12 = p3;
			SPPoint p13 = p12;
			
			Assert.True(p2.X == 8.0f);
			Assert.True(p2.Y == 16.0f);
			Assert.True(p2.Length > 17.0f);
			Assert.True(p2.Length < 18.0f);
			Assert.True(p2.LengthSquared == 320.0f);
			Assert.True(p2.Angle != 0.0f);
			Assert.True(p1.IsOrigin);
			Assert.True(p3.X == 4.0f);
			Assert.True(p3.Y == 8.0f);
			Assert.True(((int)p4.Y) == -4);
			Assert.True(p5.Y > 0.8f);
			Assert.True(p6.Y == -8.0f);
			Assert.True(p7 == p2);
			Assert.True(f1 == p2.Length);
			Assert.True(f2 > 1.5f);
			Assert.True(f3 < 0.0f);
			Assert.True(p8.X == 4.0f);
			Assert.True(p8.Y == 8.0f);
			Assert.True(p9.X == 12.0f);
			Assert.True(p9.Y == 24.0f);
			Assert.True(p10.X == -8.0f);
			Assert.True(p10.Y == -16.0f);
			Assert.True(p11.X == p3.X);
			Assert.True(p11.Y == p3.Y);
			Assert.True(p11 == p3);
			Assert.False(p11 != p3);
			Assert.True(p3 == p13);
			
			#endregion
		}
	}
}
