[Sparrow Framework 1.3 MonoTouch Documentation](../index.md) 
# SPTexture

	public class SPTexture : NSObject
	
A texture stores the information that represents an image. It cannot be displayed directly, but has to be mapped onto a display object. In Sparrow, that display object is [SPImage](SPImage.md).
 
**Image formats**
 
Sparrow supports different file formats for textures. The most common formats are `PNG`, which contains an alpha channel, and `JPG` (without an alpha channel). You can also load files in the `PVR` format (compressed or uncompressed). That's a special format of the graphics chip of iOS devices that is very efficient.
 
**HD textures**
 
Furthermore, Sparrow supports development in multiple resolutions, i.e. creating a game simultaneously for normal and retina displays. If HD texture support is activated (via `SPStage.SupportHighResolutions`) and you load a texture like this:
 
	SPTexture texture = new SPTexture("image.png");
  
Sparrow will check if it finds the file `image@2x.png`, and will load that instead (provided that it is available and the application is running on a HD device). The texture object will then return values for width and height that are the original number of pixels divided by 2 (by setting their scale-factor to `2.0`). That way, you will always work with the same values for width and height - regardless of the device type.
 
It is also possible to switch textures depending on the device the app is executed on. The convention is to add a device modifier (`~ipad` or `~iphone`) to the image name, directly before the file extension (and after the scale modifier, if there is one).
 
**Drawing API**
 
Sparrow lets you create custom graphics directly at run-time by using the `Core Graphics` API.
You access the drawing API with a special init-method of SPTexture, which takes a `delegate` parameter you can fill with your drawing code. 
  
	SPTexture customTexture = new SPTexture(200.0f, 100.0f, delegate(CGContext context) {
	    // draw a string
	    context.SetFillColor(1.0f, 1.0f);
	    string text = "Hello Core Graphics";
	    // You need a UIView instance to properly draw a string with MonoTouch
	    SPStage.MainStage.NativeView.DrawString(text, new PointF(20.0f, 20.0f), 
	                                            UIFont.FromName("Arial", 25.0f));
	});

**Texture Frame**
 
The frame property of a texture allows you to define the position where the texture will appear within an [SPImage](SPImage.md). The [rectangle](SPRectangle.md) is specified in the coordinate system of the texture:
 
	texture.Frame = new SPRectangle(-10.0f, -10.0f, 30.0f, 30.0f);
	SPImage image = new SPImage(texture);
 
This code would create an [image](SPImage.md) with a size of 30x30, with the texture placed at `X=10`, `Y=10` within that image (assuming that the texture has a width and height of 10 pixels, it would appear in the middle of the image). This is especially useful when a texture has transparent areas at its sides. It is then possible to crop the texture (removing the transparent edges) and make up for that by specifying a frame. 
 
The texture class itself does not make any use of the frame data. It's up to classes that use SPTexture to support that feature.

## Properties

 - `Width` : The width of the texture in points. *(readonly)*
 - `Height` : The height of the texture in points. *(readonly)*
 - `TextureID` : The OpenGL texture ID. *(readonly)*
 - `Scale` : The scale factor, which influences `Width` and `Height` properties. *(readonly)*
 - `Frame` : The frame indicates how the texture should be displayed within an image. (Default: `null`)
 - `Repeat` : Indicates if the texture should repeat like a wallpaper or stretch the outermost pixels. Note: this makes sense only in textures with sidelengths that are powers of two and that are not loaded from a texture atlas (i.e. no subtextures). (Default: `false`)
 - `Filter` : The filter type influences how the texture appears when it is scaled up or down. (Default: `SPTextureFilter.Bilinear`)
 - `HasPremultipliedAlpha` : Indicates if the alpha values are premultiplied into the RGB values. *(readonly)*
 
## Constructors

	new SPTexture(float width, float height, SPTextureDrawingDelegate drawingDelegate)
	
Initializes a texture with a certain size (in points) and a block containing Core Graphics commands. The texture will have the current scale factor of the stage and an RGBA color space.

	new SPTexture(float width, float height, float scale, SPColorSpace colorSpace, 
		          SPTextureDrawingDelegate drawingDelegate)
	
Initializes a texture with size and color properties, as well as a block containing Core Graphics commands.

	new SPTexture(string path)
	
Initializes a texture with the contents of a file. Recommended formats: png, jpg, pvr.

	new SPTexture(UIImage image)
	
Initializes a texture with the contents of a UIImage.

	new SPTexture(SPRectangle region, SPTexture texture)
	
Initializes a texture with a [region](SPRectangle.md) (in points) of another texture. The new texture will reference the base texture; no data is duplicated.

## Methods

	public void AdjustTextureCoordinates(ref float[] texCoords, ref float[] targetTextCoords, 
	                                     int numVertices)
	                                     
Converts texture coordinates into the format required for rendering.

## Static Methods

	SPTexture EmptyTexture()

Creates an empty (white) texture. 
 
---

**See Also:**

 - [SPImage](SPImage.md) 
