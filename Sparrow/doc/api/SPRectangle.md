[Sparrow Framework 1.3 MonoTouch Documentation](../index.md) 
# SPRectangle

		public class SPRectangle : SPPoolObject

The SPRectangle class describes a rectangle by its top-left corner point (x, y) and by its width and height.

## Properties

- `X`, `Left` : The x coordinate of the rectangle.
- `Y`, `Top` : The y coordinate of the rectangle.
- `Right` : The sum of the `X` and `Width` properties.
- `Bottom` : The sum of the `Y` and `Height` properties.
- `Width` : The width of the rectangle.
- `Height` : The height of the rectangle.
- `TopLeft`, `Location` : The location of the top-left corner, determined by the x and y coordinates of the [point](SPPoint.md).
- `BottomRight` : The location of the bottom-right corner, determined by the x and y coordinates of the [point](SPPoint.md).
- `Center` : The center of the rectangle, determined by the x and y coordinates of the [point](SPPoint.md).
- `Size` : The size of the rectangle, determined by the values of the `Width` and `Height` properties.
- `IsEmpty` : Determines if the rectangle has an empty area. *(readonly)*

## Constructor

	new SPRectangle(float x, float y, float width, float height)
	new SPRectangle(SPPoint location, float width, float height)

Initializes a rectangle with the specified components.

	new SPPRectangle(SPPoint topLeft, SPPoint bottomRight)

Initializes a rectangle with top-left corner and bottom-right corner at the specified locations.

## Methods

	bool Contains(float x, float y)
	bool Contains(SPPoint point)

Determines if a point is within the rectangle.
		
	bool Contains(SPRectangle rectangle)

Determines if another rectangle is within the rectangle.
		
	bool IntersectsWith(SPRectangle rectangle)

Determines if another rectangle contains or intersects the rectangle.
		
	SPRectangle Intersect(SPRectangle rectangle)

If the specified rectangle intersects with the rectangle, returns the area of intersection.

	SPRectangle Union(SPRectangle rectangle)
		
Adds two rectangles together to create a new rectangle (by filling in the space between the two rectangles).

	SPRectangle Inflate(float x, float y)
	SPRectangle Inflate(SPPoint size)
	
Creates and returns an enlarged copy of the rectangle. 

	void Offset(float x, float y)
	void Offset(SPPoint pos)

Adjusts the location of the rectangle by the specified amount. 

	void SetEmpty();

Sets width and height components to zero.		

	SPRectangle Clone();
	
Returns a copy of the rectangle.

## Static Methods

	public static SPRectangle FromLTRB(float left, float top, float right, float bottom)
	
Creates a rectangle with top-left corner and bottom-right corner at the specified locations.
		
## Operators

	SPRectangle r3 = r1 + r2;
	
Adds the second to the first rectangle and returns a new rectangle (by filling in the space between the two rectangles).

	if (r1 == r2) { }
	if (r1 != r2) { }           
	
Compares two rectangles if they are equal or not.

	System.Drawing.RectangleF r1 = new SPRectangle(0.0f, 0.0f, 100.0f, 20.0f);
	SPRectangle r2 = new System.Drawing.RectangleF(0.0f, 0.0f, 100.0f, 20.0f);
	
Implicit convert between System and Sparrow rectangles. 

---

**See Also:**

 - [SPPoint](SPPoint.md)