using System;
using System.Collections.Generic;

namespace Sparrow
{
	public partial class SPDisplayObjectContainer : IList<SPDisplayObject>
	{
		bool ICollection<SPDisplayObject>.IsReadOnly
		{
			get { return false; }
		}
		
		public SPDisplayObject this[int index]
		{
			get { return this._ChildAtIndex(index); }
			set
			{ 
				this._AddAtIndex(value, index);
				
				int nextIndex = index + 1;
				
				if (nextIndex < this.Count)
				{
					this.RemoveAt(nextIndex);
				}
			}
		}

		public SPDisplayObject this[string name]
		{
			get { return this._ChildByName(name); }
		}

		public void Insert(int index, SPDisplayObject child)
		{
			this._AddAtIndex(child, index);
		}
		
		public bool Remove(SPDisplayObject child)
		{
			if (!this.Contains(child))
			{
				return false;
			}
			this._Remove(child);
			return true;
		}
		
		public void CopyTo(SPDisplayObject[] array, int arrayIndex)
		{
			int count = this.Count;
			for (int i = 0; i < count; i++)
			{
				array[arrayIndex + i] = this._ChildAtIndex(i);
			}
		}

		public IEnumerator<SPDisplayObject> GetEnumerator()
		{
			int num = this.Count;
			
			for (int i = 0; i < num; i++)
			{
				SPDisplayObject child = this._ChildAtIndex(i);
				yield return child;
			}
		}

		System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
	}
}

