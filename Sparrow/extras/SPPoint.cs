using System;
using MonoTouch.Foundation;

namespace Sparrow
{
	public partial class SPPoint
	{	
		public override bool Equals(object other)
		{
			if (ReferenceEquals(other, null))
			{
				return false;
			}	
			return this._IsEqual((NSObject)other);
		}
		
		public override int GetHashCode()
		{
			return (int)this.X ^ (int)this.Y;
		}
		
		public override string ToString()
		{
			return string.Format("{{X={0}, Y={1}}}", this.X.ToString(System.Globalization.CultureInfo.InvariantCulture), 
			                                         this.Y.ToString(System.Globalization.CultureInfo.InvariantCulture));
		}
		
		public static SPPoint operator +(SPPoint p1, SPPoint p2)
		{
			return p1._AddPoint(p2);
		}
		
		public static SPPoint operator -(SPPoint p1, SPPoint p2)
		{
			return p1._SubtractPoint(p2);
		}
		
		public static SPPoint operator *(SPPoint p1, float scalar)
		{
			return p1.Scale(scalar);
		}
		
		public static bool operator ==(SPPoint p1, SPPoint p2)
		{
			if (ReferenceEquals(p1, p2))
			{
				return true;
			}
			if (ReferenceEquals(p1, null) || ReferenceEquals(p2, null))
			{
				return false;
			}
    		
			return p1._IsEqual(p2);
		}
		
		public static bool operator !=(SPPoint p1, SPPoint p2)
		{
			if (ReferenceEquals(p1, p2))
			{
				return false;
			}
			if (ReferenceEquals(p1, null) || ReferenceEquals(p2, null))
			{
				return true;
			}
    		
			return !p1._IsEqual(p2);
		}
		
		public static implicit operator System.Drawing.PointF(SPPoint p)
		{
			return new System.Drawing.PointF(p.X, p.Y);
		}
		
		public static implicit operator SPPoint(System.Drawing.PointF p)
		{
			return new SPPoint(p.X, p.Y);
		}
   
	}
}