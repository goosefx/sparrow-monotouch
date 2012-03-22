[Sparrow Framework 1.3 MonoTouch Documentation](../index.md) 
# SPDisplayObjectContainer

	public abstract class SPDisplayObjectContainer : SPDisplayObject, IList<SPDisplayObject>

An SPDisplayObjectContainer represents a collection of display objects.
 
It is the base class of all display objects that act as a container for other objects. By maintaining an ordered list of children, it defines the back-to-front positioning of the children within the display tree.
 
A container does not have size in itself. The width and height properties represent the extents of its children. Changing those properties will scale all children accordingly.
 
As this is an abstract class, you can't instantiate it directly, but have to use a subclass instead. The most lightweight container class is [SPSprite](SPSprite.md).
 
**Adding and removing children**
 
The class defines methods that allow you to add or remove children. When you add a child, it will be added at the foremost position, possibly occluding a child that was added before. You can access the children via an index. The first child will have index `0`, the second child index `1`, etc. 
 
Adding and removing objects from a container triggers non-bubbling events.
 
 - `SPEventType.Added` : The [object](SPDisplayObject.md) was added to a parent.
 - `SPEventType.AddedToStage` : The [object](SPDisplayObject.md) was added to a parent that is connected to the stage, thus becoming visible now.
 - `SPEventType.Removed` : The [object](SPDisplayObject.md) was removed from a parent.
 - `SPEventType.RemovedFromStage`: the [object](SPDisplayObject.md) was removed from a parent that is connected to the [stage](SPStage.md), thus becoming invisible now.
 
Especially the `Added` [event](SPEvent.md) is very helpful, as it allows you to automatically execute some logic (e.g. start an animation) when an object is rendered the first time.
 
**Sorting children**
 
The `Sort` method allows you to sort the children of a container by a custom criteria. Below is an example how to depth-sort children by their y-coordinate; this will put objects that are lower on the screen in front of those higher on the screen.
 
	container.Sort(delegate(SPDisplayObject child1, SPDisplayObject child2) {
	    if (child1.Y < child2.Y) return NSComparisonResult.Ascending;
	    else if (child1.y > child2.y) return NSComparisonResult.Descending;
	    else return NSComparisonResult.Same;
	});
			
Instead of returning `NSComparisonResult` you can just return `-1` for ascending, `1` for descending and `0` for same. So you can return directly any `.NET` comparsion result.

	container.Sort(delegate(SPDisplayObject child1, SPDisplayObject child2) {
		return child1.Name.CompareTo(child2.Name);
	});
			
## Properties

 - `Count` : The number of children of this container. *(readonly)*
 - `[index]` : Provides the ability to get or set a child at a certain index. 
 - `[name]` : Returns a child object with a certain name (non-recursively). *(readonly)* 

## Methods

	void Add(SPDisplayObject child);

Adds a [child](SPDisplayObject.md) to the container. It will be at the topmost position.

	public void Insert(int index, SPDisplayObject child)

Adds a child to the container at a certain index.

	public bool Remove(SPDisplayObject child)

Removes a child from the container. If the object is not a child, nothing happens.

	void RemoveAt(int index);

Removes a child at a certain index. Children above the child will move down.

	void Move(int index, SPDisplayObject child);

Moves a child to a certain index. Children at and after the replaced position move up.

	void Swap(SPDisplayObject child1, SPDisplayObject child2);

Swaps the indexes of two children.
		
	void Swap(int index1, int index2);

Swaps the indexes of two children.
		
	void Clear();

Removes all children from the container.

	bool Contains(SPDisplayObject child);

Determines if a certain object is a child of the container (recursively).

	int IndexOf(SPDisplayObject child);

Returns the index of a child within the container.

	void Sort(SPDisplayObjectComparator comparator);

Sorts the children using the given comparison. Only available in iOS 4 and above!

	public void CopyTo(SPDisplayObject[] array, int arrayIndex)

Copies all children to the given array starting at the specified index.

	public IEnumerator<SPDisplayObject> GetEnumerator()

Returns an enumerator that iterates through the children of this container.

# SPDisplayObjectComparator

	public delegate int SPDisplayObjectComparator(SPDisplayObject obj1, SPDisplayObject obj2);

Represents a method to compare two [objects](SPDisplayObject.md).

---

**See Also:**

 - [SPDisplayObject](SPDisplayObject.md)
 - [SPSptrite](SPPrite.md)