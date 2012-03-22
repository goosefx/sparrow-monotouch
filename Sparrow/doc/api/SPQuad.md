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
 
**Colors**
 
[Colors](SPColor.md) in Sparrow are defined as unsigned integers, that's exactly 8 bit per color. The easiest way to define a color is by writing it as a hexadecimal number. A color has the following structure:
 
	0xRRGGBB
 
That means that you can create the base colors like this:
 
	0xFF0000 -> red
 	0x00FF00 -> green
 	0x0000FF -> blue
 
Other simple colors:
 
	0x000000 or 0x0 -> black
	0xFFFFFF        -> white
	0x808080        -> 50% gray
 
If you're not comfortable with that, there is also a utility method available that takes the values for `R`, `G` and `B` separately:
 
	uint red = SPColor.FromRGB(255, 0, 0);

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
