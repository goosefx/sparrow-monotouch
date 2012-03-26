[Sparrow Framework 1.3 MonoTouch Documentation](../index.md) 
# SPPoint

		public class SPPoint : SPPoolObject

The SPPoint class describes a two dimensional point or vector.

## Properties

- `X` : The x coordinate of the point.
- `Y` : The y coordinate of the point.
- `Length` : The distance to the origin (or the length of the vector). *(readonly)*
- `LengthSquared` :  The squared distance to the origin (or the squared length of the vector). *(readonly)*
- `Angle` : The angle between the positive x-axis and the point (in radians, CCW). *(readonly)*
- `IsOrigin` : Returns true if this point is in the origin (x and y equal zero). *(readonly)*

## Constructor

	new SPPoint(float x, float y)

Initializes a point with its x and y components.

## Methods

	SPPoint Scale(float scalar)

Scales the point by a certain factor and returns the resulting point.
		
	SPPoint Rotate(float angle)

Rotates the point by the given angle (in radians, CCW) and returns the resulting point.
		
	float Dot(SPPoint other)		
	
Returns the dot-product of this and the given point.
		
	SPPoint Normalize()

Returns a point that has the same direction but a length of one.
		
	SPPoint Invert()

Returns a point that is the inverse (negation) of this point.
		
## Static Methods

	SPPoint FromPolarLength(float length, float angle);
	
Creates a point with the distance and angle in respect to the origin.
		
	float CalculateDistance(SPPoint p1, SPPoint p2);

Calculates the distance between two points.

	float CalculateAngle(SPPoint p1, SPPoint p2);

Calculates the angle between two points.
		
	SPPoint Interpolate(SPPoint p1, SPPoint p2, float ratio);

Determines a point between two specified points. `ratio = 0 -> p1`, `ratio = 1 -> p2`

## Operators

	SPPoint p3 = p1 + p2;
	
Adds the second to the first point and returns the resulting point.

	SPPoint p3 = p1 - p2;

Subtracts the second from the first point and returns the resulting point.

	SPPoint p2 = p1 * 0.5f;
	
Scales the point by a certain factor.

	if (p1 == p2) { }
	if (p1 != p2) { }           
	
Compares two points if they are equal or not.

	System.Drawing.PointF p1 = new SPPoint(12.0f, -8.0f);
	SPPoint p2 = new System.Drawing.PointF(-8.0f, 22.0f);
	
Implicit convert between System and Sparrow points. 

---

**See Also:**

 - [SPRectangle](SPRectangle.md)