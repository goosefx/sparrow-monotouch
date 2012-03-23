[Sparrow Framework 1.3 MonoTouch Documentation](../index.md) 
# SPColor

Colors in Sparrow are defined as unsigned integers, that's exactly 8 bit per color. The easiest way to define a color is by writing it as a hexadecimal number. A color has the following structure:
 
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

## Predefined Colors

	obj.Color = SPColor.Aqua;
	
`White`, `Silver`, `Gray`, `Black`, `Red`, `Maroon`, `Yellow`, `Olive`, `Lime`, `Green`, `Aqua`, `Teal`, `Blue`, `Navy`, `Fuchsia` and `Purple`

## Static Helpers

	byte alpha = SPColor.GetAlpha(0xFF000000);
	
	byte red   = SPColor.GetRed(0xFF0000);
	byte green = SPColor.GetGreen(0x00FF00);
	byte blue  = SPColor.GetBlue(0x0000FF);
	
	uint color = SPColor.FromRGB(200, 40, 80);
	uint color = SPColor.FromRGBA(120, 200, 60, 128);
