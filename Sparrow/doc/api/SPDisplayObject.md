[Sparrow Framework 1.3 MonoTouch Documentation](../index.md) 
# SPDisplayObject

	public abstract class SPDisplayObject : SPEventDispatcher
	
The SPDisplayObject class is the base class for all objects that are rendered on the screen.

In Sparrow, all displayable objects are organized in a display tree. Only objects that are part of the display tree will be displayed (rendered). The display tree consists of leaf nodes ([SPImage](SPImage.md), [SPQuad](SPQuad.md)) that will be rendered directly to the screen, and of container nodes (subclasses of [SPDisplayObjectContainer](SPDisplayObjectContainer.md), like [SPSprite](SPSprite.md)). A container is simply a display object that has child nodes - which can, again, be either leaf nodes or other containers. 

At the root of the display tree, there is the [SPStage](SPStage.md), which is a container, too. To create a Sparrow application, you let your main class inherit from [SPStage](SPStage.md), and build up your display tree from there.

A display object has properties that define its position in relation to its parent (`X`, `Y`), as well as its `Rotation` and scaling factors (`ScaleX`, `ScaleY`). Use the `Alpha` and `Visible` properties to make an object translucent or invisible.

Every display object may be the target of touch events. If you don't want an object to be touchable, you can disable the `Touchable` property. When it's disabled, neither the object nor its children will receive any more touch events.

**Points vs. Pixels**
 
All sizes and distances are measured in points. What this means in pixels depends on the `ContentScaleFactor` of the [stage](SPStage.md). On a low resolution device (up to iPhone 3GS), one point is one pixel. On devices with a retina display, one point may be 2 pixels.

**Transforming coordinates**
 
Within the display tree, each object has its own local coordinate system. If you rotate a container, you rotate that coordinate system - and thus all the children of the container.
 
Sometimes you need to know where a certain point lies relative to another coordinate system. That's the purpose of the method `TransformationMatrixToSpace`. It will create a [matrix](SPMatrix.md) that represents the transformation of a point in one coordinate system to another. 

**Subclassing SPDisplayObject**
 
As SPDisplayObject is an abstract class, you can't instantiate it directly, but have to use one of its subclasses instead. There are already a lot of them available, and most of the time they will suffice. 
 
However, you can create custom subclasses as well. That's especially useful when you want to create an object with a custom render function.
 
You will need to implement the following methods when you subclass SPDisplayObject:
 
	public virtual void Render(SPRenderSupport support);
	public virtual SPRectangle BoundsInSpace(SPDisplayObject targetCoordinateSpace);

## Properties

 - `X` : The x coordinate of the object relative to the local coordinates of the parent.
 - `Y` : The y coordinate of the object relative to the local coordinates of the parent.
 - `PivotX` : The x coordinate of the object's origin in its own coordinate space (default: `0`).
 - `PivotY` : The y coordinate of the object's origin in its own coordinate space (default: `0`).
 - `ScaleX` : The horizontal scale factor. `1` means no scale, negative values flip the object.
 - `ScaleY` : The vertical scale factor. `1` means no scale, negative values flip the object. 
 - `Width` : The width of the object in points.
 - `Height` : The height of the object in points.
 - `Rotation` : The rotation of the object in radians. (In Sparrow, all angles are measured in radians.)
 - `Alpha` : The opacity of the object. `0` = transparent, `1` = opaque.
 - `Visible` : The visibility of the object. An invisible object will be untouchable.
 - `Touchable` : Indicates if this object (and its children) will receive touch events.
 - `Name` : The name of the display object (default: null). Used by display object containers.
 - `Bounds` : The [bounds](SPRectangle.md) of the object relative to the local coordinates of the parent. *(readonly)*
 - `Parent` : The display object [container](SPDisplayObjectContainer.md) that contains this display object. *(readonly)*
 - `Root` : The topmost [object](SPDisplayObject.md) in the display tree the object is part of. *(readonly)*
 - `Stage` : The [stage](SPStage.md) the display object is connected to, or null if it is not connected to a stage. *(readonly)*
 - `TransformationMatrix` : The transformation matrix of the object relative to its parent. *(readonly)*
 
## Events

 - `Added` : The object was added to a parent. 
 - `AddedToStage` : the object was added to a parent that is connected to the [stage](SPStage.md), thus becoming visible now.
 - `Removed` : The object was removed from a parent. 
 - `RemovedFromStage` : The object was removed from a parent that is connected to the [stage](SPStage.md), thus becoming invisible now. 
 
**Here is a sample:**

	// anonymous delegate
	obj.AddedToStage += delegate(SPEventDispatcher sender, SPEventArgs e) {
		// do something
	}; 
	
	// binding to a receiver method
	obj.RemovedFromStage += new SPEventHandler(ObjectRemovedFromStage);
	
	private void ObjectRemovedFromStage(SPEventDispatcher sender, SPEventArgs e) {
		// do something
	}
	
	// native event listening
	obj.AddEventLstener(SPEventType.Added, 
	    (SPEventHandler)delegate(SPEventDispatcher object, SPEventArgs e) {
	        // an added event was triggered
	    }
	);

## Methods

	void Render(SPRenderSupport support);
		
Renders the display object with the help of a [support object](SPRenderSupport.md). 

	void RemoveFromParent();

Removes the object from its parent, if it has one.
		
	SPMatrix TransformationMatrixToSpace(SPDisplayObject targetCoordinateSpace);

Creates a [matrix](SPMatrix.md) that represents the transformation from the local coordinate system to another.

	SPRectangle BoundsInSpace(SPDisplayObject targetCoordinateSpace);

Returns a [rectangle](SPRectangle.md) that completely encloses the [object](SPDisplayObject.md) as it appears in another coordinate system.

	SPPoint LocalToGlobal(SPPoint localPoint);

Transforms a [point](SPPoint.md) from the local coordinate system to global (stage) coordinates.
		
	SPPoint GlobalToLocal(SPPoint globalPoint);

Transforms a [point](SPPoint.md) from global (stage) coordinates to the local coordinate system.

	SPDisplayObject HitTest(SPPoint localPoint, bool isTouch);
		
Returns the [object](SPDisplayObject) that is found topmost on a point in local coordinates, or null if the test fails.

	void BroadcastEvent(SPEvent event);

Dispatches an [event](SPEvent.md) on all children (recursively). The event must not bubble.

---	
 
**See Also:**
 
 - [SPEvent](SPEvent.md)
 - [SPEventDispatcher](SPEventDispatcher.md)
