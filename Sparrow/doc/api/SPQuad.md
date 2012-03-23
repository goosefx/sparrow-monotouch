[Sparrow Framework 1.3 MonoTouch Documentation](../index.md) 
# SPQuad

	public class SPQuad : SPDisplayObject

An SPQuad represents a rectangle with a uniform color or a color gradient. 
 
You can set one color per vertex. The colors will smoothly fade into each other over the area of the quad. To display a simple linear color gradient, assign one color to vertices `0` and `1` and 
another color to vertices `2` and `3`.
 
The indices of the vertices are arranged like this:
 
	0 - 1
	| / |
	2 - 3
 
## Properties

 - `Color` : Sets the colors of all vertices simultaneously. Returns the [color](SPCOlor.md) of vertex `0`.	

## Constructors

	new SPQuad()

Initializes a 32x32 white quad.

	new SPQuad(float width, float height[, uint color = SPColor.White])

Initializes a quad with a certain size (and color).

## Methods

	void SetColor(uint color, int vertexID);
		
Sets the color of a vertex.
		
	uint GetColor(int vertexID);

Returns the color of a vertex.

---

**See Also:**

 - [SPColor](SPColor.md)
 - [SPDisplayObject](SPDisplayObject.md)
