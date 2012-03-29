[Sparrow Framework 1.3 MonoTouch Documentation](../index.md) 
# SPImage

	public class SPImage : SPQuad

An SPImage displays a [quad](SPQuad.md) with a texture mapped onto it.

Sparrow uses the SPTexture class to represent textures. To display a texture, you have to map it on a [quad](SPQuad.md) - and that's what SPImage is for.

As SPImage inherits from [SPQuad](SPQuad.md), you can give it a [color](SPColor.md). For each pixel, the resulting color will be the result of the multiplication of the color of the texture with the color of the quad. That way, you can easily tint textures with a certain color. 

Furthermore, SPImage allows the manipulation of texture coordinates. That way, you can move a [texture](SPTexture.md) inside an image without changing any vertex coordinates of the quad. You can also use this feature as a very efficient way to create a rectangular mask.

## Properties

 - `Texture` : The texture that is displayed on the quad.

## Constructors

	new SPImage(SPTexture texture)
	
Initialize a quad with a texture mapped onto it.

	new SPImage(string path)
	
Initialize a quad with a texture loaded from a file.

## Methods

	void SetTexCoords(SPPoint coords, int vertexID)

Sets the [texture](SPTexture.md) coordinates of a vertex. Coordinates are in the range `[0.0f, 1.0f]`.	
		
	SPPoint GetTexCoords(int vertexID)

Gets the [texture](SPTexture.md) coordinates of a vertex.

---

**See Also:**

 - [SPColor](SPColor.md)
 - [SPDisplayObject](SPDisplayObject.md)
 - [SPQuad](SPQuad.md)
 - [SPTexture](SPTexture.md)