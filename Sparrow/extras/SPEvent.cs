using System;

namespace Sparrow
{
	public interface SPEventArgs
	{
		string EventType
		{
			get;
		}
		
		bool Bubbles
		{
			get;
			set;
		}
		
		bool Cancel
		{
			get;
			set;
		}
		
		SPEventDispatcher Origin
		{
			get;
		}
	}
	
	public partial class SPEvent : SPEventArgs
	{
		bool SPEventArgs.Bubbles
		{
			get
			{
				if (this._StopsPropagation())
				{
					return false;
				}
				return this.Bubbles;
			}
			set
			{
				if (!value)
				{
					this.StopPropagation();
				}
				else if (this._StopsPropagation())
				{
					throw new InvalidOperationException();
				}
			}
		}
		
		bool SPEventArgs.Cancel
		{
			get
			{
				if (this._StopsImmediatePropagation())
				{
					return true;
				}
				return false;
			}
			set
			{
				if (value)
				{
					this.StopImmediatePropagation();
				}
				else if (this._StopsImmediatePropagation())
				{
					throw new InvalidOperationException();
				}
			}
		}
		
		SPEventDispatcher SPEventArgs.Origin
		{
			get
			{ 
				return this.Target;
			}
		}
		
	}
}

