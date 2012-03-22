using System;

namespace Sparrow
{
	public static class SPColor
	{
		public const uint White = 0xffffff;
		public const uint Silver = 0xc0c0c0;
		public const uint Gray = 0x808080;
		public const uint Black = 0x000000;
		public const uint Red = 0xff0000;
		public const uint Maroon = 0x800000;
		public const uint Yellow = 0xffff00;
		public const uint Olive = 0x808000;
		public const uint Lime = 0x00ff00;
		public const uint Green = 0x008000;
		public const uint Aqua = 0x00ffff;
		public const uint Teal = 0x008080;
		public const uint Blue = 0x0000ff;
		public const uint Navy = 0x000080;
		public const uint Fuchsia = 0xff00ff;
		public const uint Purple = 0x800080;		
		
		public static byte GetAlpha(uint color)
		{
			return (byte)(((color) >> 24) & 0xff);
		}
		
		public static byte GetRed(uint color)
		{
			return (byte)(((color) >> 16) & 0xff);
		}
		
		public static byte GetGreen(uint color)
		{
			return (byte)(((color) >> 8) & 0xff);
		}
		
		public static byte GetBlue(uint color)
		{
			return (byte)(color & 0xff);
		}
		
		public static uint FromRGB(byte r, byte g, byte b)
		{
			return (uint)(((int)(r) << 16) | ((int)(g) << 8) | (int)(b));
		}
		
		public static uint FromRGBA(byte r, byte g, byte b, byte a)
		{
			return (uint)(((int)(a) << 24) | ((int)(r) << 16) | ((int)(g) << 8) | (int)(b));
		}
	}
}

