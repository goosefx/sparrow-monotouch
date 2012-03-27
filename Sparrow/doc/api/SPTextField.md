[Sparrow Framework 1.3 MonoTouch Documentation](../index.md) 
# SPTextField

	public class SPTextField : SPDisplayObjectContainer
	
An SPTextField displays text, either using standard iOS fonts or a custom bitmap font.

You can set all properties you are used to, like the font name and size, a color, the horizontal and vertical alignment, etc. The border property is helpful during development, because it lets you see the bounds of the textfield.
 
**There are two types of fonts that can be displayed:**
 
 - Standard iOS fonts. This renders the text with standard iOS fonts like Verdana or Arial. Use this method if you want to keep it simple, and if the text changes not too often. Simply pass the font name to the corresponding property.
 - Bitmap fonts. If you need speed or fancy font effects, use a bitmap font instead. That is a font that has its glyphs rendered to a texture atlas. To use it, first register the font with the method `RegisterBitmapFont`, and then pass the font name to the corresponding property of the text field.
    
**For the latter, we recommend one of the following tools (both support Sparrow natively):**
 
 - [Glyph Designer](http://glyphdesigner.71squared.com) from 71squared. 
 - [bmGlyph](http://www.bmglyph.com) available in the App Store. 
  
Alternatively, you can use the [Bitmap Font Generator](http://www.angelcode.com/products/bmfont) from Angel Code, which is a free tool for Windows. Export the font data as an XML file and the texture as a png with white characters on a transparent background (32 bit). 
 
**Here is a sample with a standard font:**
 
	SPTextField textField = new SPTextField(300.0f, 100.0f, "Hello world!");
	textField.HorizontalAlignment = SPHorizontalAlignment.Center;
	textField.VerticalAlignment = SPVerticalAlign.Center;
	textField.FontSize = 18.0f;
	textField.FontName = "Georgia-Bold"; 
 
 **And now we use a bitmap font:**

	// Register the font; the returned font name is the one that is defined in the font XML.
	string fontName = SPTextField.RegisterBitmapFont("bitmap_font.fnt"); 
	
	SPTextField textField = new SPTextField(300.0f, 100.0f, "Hello world!");
	textField.FontName = fontName;
 
## Constants

 - `DefaultFontName = "Helvetica"`
 - `DefaultFontSize = 14.0f`
 - `DefaultFontColor = SPColor.Black`
 - `NativeFontSize = -1.0f` 
 
## Properties
 
 - `Text` : The displayed text.
 - `FontName` : The name of the font.
 - `FontSize` : The size of the font. For bitmap fonts, use `SPTextField.NativeFontSize` for the original size.

 - `HorizontalAlignment` : The horizontal alignment of the text.
 - `VerticalAlignment` : The vertical alignment of the text.
 - `Border` : Allows displaying a border around the edges of the text field. Useful for visual debugging.
 - `Color` : The [color](SPColor.md) of the text.
 - `TextBounds` : The [bounds](SPRectangle.md) of the actual characters inside the text field. */readonly)*
 - `Kerning` : Allows using kerning information with a bitmap font (where available). Default is `true`.
		 
## Constructors

	new SPTextField(float width, float height, string text, string fontName, float size, uint color)
	
Initialize a text field with all important font properties.

	new SPTextField(float width, float height, string text)

Initialize a text field with default settings (Helvetica, 14pt, black).

	new SPTextField(string text)

Initialize a 128x128 text field with default settings (Helvetica, 14pt, black).
 
## Static Methods

	string RegisterBitmapFont(string path, SPTexture texture);
		
Makes a bitmap font available at any text field, manually providing the [texture](SPTexture.md).

	string RegisterBitmapFont(string path);
		
Makes a bitmap font available at any text field, using the [texture](SPTexture.md) defined in the file.

	void UnregisterBitmapFont(string name);

Releases the bitmap font.

---

**See Also:**

 - [SPEventDispatcher](SPEventDispatcher.md)
 - [SPDisplayObject](SPDisplayObject.md)
 - [SPDisplayObjectContainer](SPDisplayObjectContainer.md)