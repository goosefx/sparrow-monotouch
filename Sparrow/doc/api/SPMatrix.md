[Sparrow Framework 1.3 MonoTouch Documentation](../index.md) 
# SPMatrix

	public class SPMatrix : SPPoolObject, ICloneable

The SPMatrix class describes an affine, 2D transformation Matrix. It provides methods to manipulate the matrix in convenient ways, and can be used to transform points.
 
The matrix has the following form:

	|A  C Tx|
	|B  D Ty|
	|0  0  1|

## Properties

 - `A`, `B`, `C`, `D` : The a, b, c or d component of the matrix.
 - `Tx`, `Ty` : The tx or ty component of the matrix. 
 - `Determinant` : The determinat of the matrix. *(readonly)*

## Constructor

	new SPMatrix(float a, float b, float c, float d, float tx, float ty)
	
Initializes a matrix with the specified components.

	new SPMatrix()
	
Initializes an identity matrix.

## Methods

	void Set(float a, float b, float c, float d, float tx, float ty);

Sets all components simultaneously.
			
	void Concat(SPMatrix matrix);

Concatenates a matrix with the current matrix, combining the geometric effects of the two.
		
	void Translate(float dx, float dy);

Translates the matrix along the x and y axes.
		
	void Scale(float sx, float sy);

Applies a scaling transformation to the matrix.
		
	void Scale(float scale);

Applies a uniform scaling transformation to the matrix.
		
	void Rotate(float angle);

Applies a rotation on the matrix (angle in radians).
		
	void Invert();

Performs the opposite transformation of the matrix.
		
	void SetIdentity();

Sets each matrix property to a value that causes a null transformation.
		
	SPPoint Transform(SPPoint point);

Applies the geometric transformation represented by the matrix to the specified [point](SPPoint.md).

	SPMatrix Clone();
	
Returns a copy of the matrix.
		
## Static Methods

	public static int PurgePool()
	
Purge all unused objects. 
		
## Operators

	if (r1 == r2) { }
	if (r1 != r2) { }           
	
Compares two matrices if they are equal or not.

---

**See Also:**

 - [SPPoolObject](SPPoolObject.md)
 - [SPPoint](SPPoint.md)