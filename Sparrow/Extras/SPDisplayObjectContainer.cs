using System;
using System.Collections.Generic;

namespace Sparrow
{
	public partial class SPDisplayObjectContainer : IList<SPDisplayObject>
	{
		/// <summary>
		/// Always false.
		/// </summary>
		public bool IsReadOnly
		{
			get { return false; }
		}

		/// <summary>
		/// Gets or sets a child object at a certain index.
		/// </summary>
		public SPDisplayObject this[int index]
		{
			get { return this.InternalChildAtIndex(index); }
			set
			{ 
				this.InternalAddAtIndex(value, index);
				
				int nextIndex = index + 1;
				
				if (nextIndex < this.Count)
				{
					this.RemoveAt(nextIndex);
				}
			}
		}

		/// <summary>
		/// Returns a child object with a certain name (non-recursively).
		/// </summary>
		public SPDisplayObject this[string name]
		{
			get { return this.InternalChildByName(name); }
		}

		/// <summary>
		/// Adds a child to the container at a certain index.
		/// </summary>
		public void Insert(int index, SPDisplayObject child)
		{
			this.InternalAddAtIndex(child, index);
		}
		
		/// <summary>
		/// Removes a child from the container. If the object is not a child, nothing happens.
		/// </summary>
		public bool Remove(SPDisplayObject child)
		{
			if (!this.Contains(child))
			{
				return false;
			}
			this.InternalRemove(child);
			return true;
		}
		
		/// <summary>
		/// Copies all children to the given array starting at the specified index.
		/// </summary>
		public void CopyTo(SPDisplayObject[] array, int arrayIndex)
		{
			int count = this.Count;
			for (int i = 0; i < count; i++)
			{
				array[arrayIndex + i] = this.InternalChildAtIndex(i);
			}
		}

		public IEnumerator<SPDisplayObject> GetEnumerator()
		{
			int num = this.Count;
			
			for (int i = 0; i < num; i++)
			{
				SPDisplayObject child = this.InternalChildAtIndex(i);
				yield return child;
			}
		}

		System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
	}
}

