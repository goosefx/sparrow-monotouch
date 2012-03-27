using System;
using MonoTouch.CoreGraphics;
using MonoTouch.Foundation;

namespace Sparrow
{
	public enum SPHorizontalAlignment
	{
		Left = 0,
		Center,
		Right
	}

	public enum SPVerticalAlignment
	{
		Top = 0,
		Center,
		Bottom
	}
	
	public enum SPColorSpace 
	{
    	RGBA,
    	Alpha
	}	
	
	public enum SPTextureFilter
	{
    	NearestNeighbor,
    	Bilinear,
    	Trilinear
	} 
}

