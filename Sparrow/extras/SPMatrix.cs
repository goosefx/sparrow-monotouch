using System;
using MonoTouch.Foundation;

namespace Sparrow
{
	public partial class SPMatrix : ICloneable
	{
		public override int GetHashCode()
		{
			return (int)(this.A + this.B + this.C + this.D + this.Tx + this.Ty);
		}
		
		public override bool Equals(object other)
		{
			if (ReferenceEquals(other, null))
			{
				return false;
			}	
			return this._IsEqual((NSObject)other);
		}
		
		public override string ToString()
		{
			return string.Format("{{A={0}, B={1}, C={2}, D={3}, Tx={4}, Ty={5}}}",
			                     this.A.ToString(System.Globalization.CultureInfo.InvariantCulture), 
			                     this.B.ToString(System.Globalization.CultureInfo.InvariantCulture), 
			                     this.C.ToString(System.Globalization.CultureInfo.InvariantCulture), 
			                     this.D.ToString(System.Globalization.CultureInfo.InvariantCulture), 
			                     this.Tx.ToString(System.Globalization.CultureInfo.InvariantCulture), 
			                     this.Ty.ToString(System.Globalization.CultureInfo.InvariantCulture));
		}
		
		public SPMatrix Clone()
		{
			return new SPMatrix(this.A, this.B, this.C, this.D, this.Tx, this.Ty);
		}
		
		public static bool operator ==(SPMatrix m1, SPMatrix m2)
		{
			if (ReferenceEquals(m1, m2))
			{
				return true;
			}
			if (ReferenceEquals(m1, null) || ReferenceEquals(m2, null))
			{
				return false;
			}
    		
			return m1._IsEqual(m2);
		}
		
		public static bool operator !=(SPMatrix m1, SPMatrix m2)
		{
			if (ReferenceEquals(m1, m2))
			{
				return false;
			}
			if (ReferenceEquals(m1, null) || ReferenceEquals(m2, null))
			{
				return true;
			}
    		
			return !m1._IsEqual(m2);
		}

		#region ICloneable implementation
		object ICloneable.Clone()
		{
			return this.Clone();
		}
		#endregion

	}
}

