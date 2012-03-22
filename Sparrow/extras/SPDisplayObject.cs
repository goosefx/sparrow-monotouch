using System;

namespace Sparrow
{
	public partial class SPDisplayObject
	{
		public event SPEventHandler Added
		{
			add
			{
				this.AddEventListener(SPEventType.Added, value);
			}
			remove
			{
				this.RemoveEventListener(SPEventType.Added, value);
			}
		}

		public event SPEventHandler AddedToStage
		{
			add
			{
				this.AddEventListener(SPEventType.AddedToStage, value);
			}
			remove
			{
				this.RemoveEventListener(SPEventType.Added, value);
			}
		}

		public event SPEventHandler Removed
		{
			add
			{
				this.AddEventListener(SPEventType.Removed, value);
			}
			remove
			{
				this.RemoveEventListener(SPEventType.Removed, value);
			}
		}

		public event SPEventHandler RemovedFromStage
		{
			add
			{
				this.AddEventListener(SPEventType.RemovedFromStage, value);
			}
			remove
			{
				this.RemoveEventListener(SPEventType.RemovedFromStage, value);
			}
		}

	}
}

