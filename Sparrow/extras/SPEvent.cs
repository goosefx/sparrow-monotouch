using System;

namespace Sparrow
{
	/// <remarks>
	/// The SPEventArgs class contains the event data.
	/// </remarks>
	public interface SPEventArgs
	{
		/// <summary>
		/// A string that identifies the event.
		/// </summary>
		string EventType
		{
			get;
		}
		
		/// <summary>
		/// Indicates if event will bubble.
		/// </summary>
		bool Bubbles
		{
			get;
			set;
		}
		
		/// <summary>
		/// Prevents any other listeners from receiving the event.
		/// </summary>
		bool Cancel
		{
			get;
			set;
		}
		
		/// <summary>
		/// The object that dispatched the event.
		/// </summary>
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

