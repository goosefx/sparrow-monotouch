using System;
using NUnit.Framework;
using MonoTouch.Foundation;
using Sparrow;
using System.Collections.Generic;

namespace UnitTests
{
	[TestFixture]
    public class SPDisplayObjectContainerTests
	{
		
		[Test]
		public void Add()
		{
			#region ...

			SPDisplayObject child1 = new SPQuad(32.0f, 32.0f);
			SPDisplayObject child2 = new SPQuad(32.0f, 32.0f);
			SPDisplayObject child3 = new SPQuad(32.0f, 32.0f);
			SPDisplayObject child4 = new SPQuad(32.0f, 32.0f);
			
			Assert.True(child1 != child2);
			Assert.True(child2 != child3);
			
			SPDisplayObjectContainer container = new SPStage();
			container.Add(child1);
			
			Assert.True(container.Count == 1);
			
			Assert.True(container.IndexOf(child1) == 0);
			Assert.True(container.IndexOf(child2) == -1);
			
			Assert.True(container[0] == child1);
			Assert.False(container[0] == child2);
			
			Assert.True(container.Contains(child1));
			Assert.False(container.Contains(child2));

			container.Add(child3);
			container.Add(child2);
			
			Assert.True(container.Count == 3);
			
			Assert.True(container.IndexOf(child1) == 0);
			Assert.True(container.IndexOf(child2) == 2);
			Assert.True(container.IndexOf(child3) == 1);
			
			Assert.True(container[0] == child1);
			Assert.True(container[1] == child3);
			Assert.True(container[2] == child2);
			
			Assert.True(container.Contains(child1));
			Assert.True(container.Contains(child2));
			Assert.True(container.Contains(child3));
			
			container[1] = child4;

			Assert.True(container.Contains(child1));
			Assert.True(container.Contains(child2));
			Assert.False(container.Contains(child3));
			Assert.True(container.Contains(child4));
			
			Assert.True(container.Count == 3);
			
			#endregion
		}

		[Test]
		public void Insert()
		{
			#region ...
			
			SPDisplayObject child1 = new SPQuad(32.0f, 32.0f);
			SPDisplayObject child2 = new SPQuad(32.0f, 32.0f);
			SPDisplayObject child3 = new SPQuad(32.0f, 32.0f);
			
			SPDisplayObjectContainer container = new SPStage();
			container.Add(child1);
			container.Add(child3);
			container.Insert(1, child2);
			
			Assert.True(container.Count == 3);
			
			Assert.True(container.IndexOf(child1) == 0);
			Assert.True(container.IndexOf(child2) == 1);
			Assert.True(container.IndexOf(child3) == 2);
			
			#endregion
		}
		
		[Test]
		public void MoveAndRemove()
		{
			#region ...
			
			SPDisplayObjectContainer container = new SPStage();
			
			SPDisplayObject obj1 = new SPQuad(32.0f, 32.0f);
			SPDisplayObject obj2 = new SPQuad(32.0f, 32.0f);
			SPDisplayObject obj3 = new SPQuad(32.0f, 32.0f);
			SPDisplayObject obj4 = new SPQuad(32.0f, 32.0f);
			
			container.Add(obj1);
			container.Add(obj2);
			container.Add(obj3);
			container.Add(obj4);
			
			Assert.True(container.Count == 4);
			Assert.True(container.IndexOf(obj4) == 3);
			
			container.Move(1, obj4);
			
			Assert.True(container.Count == 4);
			Assert.True(container.IndexOf(obj4) == 1);
			Assert.True(container.IndexOf(obj2) == 2);
			
			Assert.True(container.Remove(obj3));
			Assert.False(container.Remove(obj3));
			
			Assert.True(container.Count == 3);
			Assert.False(container.Contains(obj3));
			
			container.RemoveAt(1);
			
			Assert.True(container.Count == 2);
			Assert.False(container.Contains(obj4));
			
			container.Clear();
			
			Assert.True(container.Count == 0);
			
			#endregion
		}
		
		[Test]
		public void Swap()
		{
			#region ...
			
			SPDisplayObjectContainer container = new SPStage();
			
			SPDisplayObject obj1 = new SPQuad(32.0f, 32.0f);
			SPDisplayObject obj2 = new SPQuad(32.0f, 32.0f);
			SPDisplayObject obj3 = new SPQuad(32.0f, 32.0f);
			SPDisplayObject obj4 = new SPQuad(32.0f, 32.0f);
			
			container.Add(obj1);
			container.Add(obj2);
			container.Add(obj3);
			container.Add(obj4);
			
			container.Swap(obj1, obj4);
			container.Swap(2, 1);
			
			Assert.True(container.IndexOf(obj1) == 3);
			Assert.True(container.IndexOf(obj2) == 2);
			Assert.True(container.IndexOf(obj3) == 1);
			Assert.True(container.IndexOf(obj4) == 0);

			#endregion
		}
		
		[Test]
		[Ignore("Bug or mapping problem?")]
		public void Sort()
		{
			#region ...
			
			SPDisplayObjectContainer container = new SPStage();
			
			SPDisplayObject obj1 = new SPQuad(32.0f, 32.0f);
			SPDisplayObject obj2 = new SPQuad(32.0f, 32.0f);
			SPDisplayObject obj3 = new SPQuad(32.0f, 32.0f);
			SPDisplayObject obj4 = new SPQuad(32.0f, 32.0f);
			
			obj1.Name = "Apple";
			obj2.Name = "Pear";
			obj3.Name = "Banana";
			obj4.Name = "Peach";
			
			container.Add(obj1);
			container.Add(obj2);
			container.Add(obj3);
			container.Add(obj4);
			
			Console.WriteLine("BEFORE");
			Console.WriteLine("{0}: {1}", 0, container[0].Name);
			Console.WriteLine("{0}: {1}", 1, container[1].Name);
			Console.WriteLine("{0}: {1}", 2, container[2].Name);
			Console.WriteLine("{0}: {1}", 3, container[3].Name);

			container.Sort(delegate(SPDisplayObject o1, SPDisplayObject o2) {
				return o1.Name.CompareTo(o2.Name);
			});
			
			Console.WriteLine("AFTER:");
			Console.WriteLine("{0}: {1}", 0, container[0].Name);
			Console.WriteLine("{0}: {1}", 1, container[1].Name);
			Console.WriteLine("{0}: {1}", 2, container[2].Name);
			Console.WriteLine("{0}: {1}", 3, container[3].Name);
		
			Assert.True(container[0] == obj1);
			Assert.True(container[1] == obj3);
			Assert.True(container[2] == obj4);
			Assert.True(container[3] == obj2);
					
			#endregion
		}
		
		[Test]
		public void Enumerator()
		{
			#region ...
			
			SPDisplayObjectContainer container = new SPStage();
			
			SPDisplayObject obj1 = new SPQuad(32.0f, 32.0f);
			SPDisplayObject obj2 = new SPQuad(32.0f, 32.0f);
			SPDisplayObject obj3 = new SPQuad(32.0f, 32.0f);
			SPDisplayObject obj4 = new SPQuad(32.0f, 32.0f);
			
			obj1.Name = "Apple";
			obj2.Name = "Pear";
			obj3.Name = "Banana";
			obj4.Name = "Peach";
			
			container.Add(obj1);
			container.Add(obj2);
			container.Add(obj3);
			container.Add(obj4);
				
			int counter = 0;
			string names = null;
			
			foreach (SPDisplayObject obj in container)
			{
				counter++;
				names = names == null ? obj.Name : names + "," + obj.Name;
			}
			
			Assert.True(counter == 4);
			Assert.True(names == "Apple,Pear,Banana,Peach");
			
			#endregion
		}
	}
}
