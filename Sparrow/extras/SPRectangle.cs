using System;

namespace Sparrow
{
	public partial class SPRectangle : ICloneable
	{
		public static SPRectangle FromLTRB(float left, float top, float right, float bottom)
		{
			return new SPRectangle(left, top, right - left, bottom - top);
		}
		
		public SPPoint Center
		{
			get
			{
				return new SPPoint(this.X + (this.Width / 2.0f),
				                   this.Y + (this.Height / 2.0f));
			}
			set
			{
				this.X = value.X - (this.Width / 2.0f);
				this.Y = value.Y - (this.Height / 2.0f);
			}
		}

		public SPRectangle(SPPoint location, float width, float height) : this(location.X, location.Y, width, height)
		{
		}

		public SPRectangle(SPPoint topLeft, SPPoint bottomRight) : this(topLeft.X, topLeft.Y, 
		                                                                bottomRight.X - topLeft.X,
		                                                                bottomRight.Y - topLeft.Y)
		{
		}
		
		public void Offset(float x, float y)
		{
			this.X += x;
			this.Y += y;
		}
		
		public void Offset(SPPoint pos)
		{
			this.Offset(pos.X, pos.Y);
		}
		
		public SPRectangle Inflate(float x, float y)
		{
			return new SPRectangle(this.X - x, this.Y - y, 
			                       this.Width + (x * 2.0f),
			                       this.Height + (y * 2.0f));
		}

		public SPRectangle Inflate(SPPoint size)
		{
			return this.Inflate(size.X, size.Y);
			//
			// TODO: The next statement produce "funny" results, but why? A Bug?
			//
			// return new SPRectangle(this.X - Size.X, this.Y - size.Y, 
			//                        this.Width + (Size.X * 2.0f),
			//                        this.Height + (Size.Y * 2.0f));
		}
		
		public override bool Equals(object other)
		{
			if (ReferenceEquals(other, null))
			{
				return false;
			}
			
			SPRectangle otherRect = other as SPRectangle;
			
			if (ReferenceEquals(otherRect, null))
			{
				return false;
			}
			
			return this.X == otherRect.X && this.Y == otherRect.Y &&
			       this.Width == otherRect.Width &&
			       this.Height == otherRect.Height; 
		}
		
		public override int GetHashCode()
		{
			return (int)(this.X + this.Y + this.Width + this.Height);
		}
		
		public override string ToString()
		{
			return string.Format("{{X={0}, Y={1}, Width={2}, Height={3}}}", 
			                     this.X.ToString(System.Globalization.CultureInfo.InvariantCulture), 
			                     this.Y.ToString(System.Globalization.CultureInfo.InvariantCulture), 
			                     this.Width.ToString(System.Globalization.CultureInfo.InvariantCulture), 
			                     this.Height.ToString(System.Globalization.CultureInfo.InvariantCulture));
		}
		
		public SPRectangle Clone()
		{
			return new SPRectangle(this.X, this.Y, this.Width, this.Height);
		}
		
		public static SPRectangle operator +(SPRectangle r1, SPRectangle r2)
		{
			return r1.Union(r2);
		}
		public static bool operator ==(SPRectangle r1, SPRectangle r2)
		{
			if (ReferenceEquals(r1, r2))
			{
				return true;
			}
			if (ReferenceEquals(r1, null))
			{
				return false;
			}
    		
			return r1.Equals(r2);
		}
		
		public static bool operator !=(SPRectangle r1, SPRectangle r2)
		{
			if (ReferenceEquals(r1, r2))
			{
				return false;
			}
			if (ReferenceEquals(r1, null))
			{
				return true;
			}
    		
			return !r1.Equals(r2);
		}
		
		public static implicit operator System.Drawing.RectangleF(SPRectangle r)
		{
			return new System.Drawing.RectangleF(r.X, r.Y, r.Width, r.Height);
		}
		
		public static implicit operator SPRectangle(System.Drawing.RectangleF r)
		{
			return new SPRectangle(r.X, r.Y, r.Width, r.Height);
		}
   		
		#region ICloneable implementation
		object ICloneable.Clone ()
		{
			return this.Clone();
		}
		#endregion
	}
}

