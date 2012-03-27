using System;

namespace Sparrow
{
	public partial class SPStage
	{
		public static bool DoubleResolutionsOnPad
		{
			get
			{
				return _DoubleResolutionsOnPad;	
			}
			set
			{
				_SetSupportHighResolutions(SupportHighResolutions, value);
			}
		}
		
	}
}

