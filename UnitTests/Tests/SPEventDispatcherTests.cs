using System;
using MonoTouch.Foundation;
using NUnit.Framework;
using Sparrow;

namespace UnitTests
{
	[TestFixture]
    public class SPEventDispatcherTests
	{
		[Test]
		public void AddAndRemoveEventListener()
		{
			#region ...
			
			SPStage dispatcher = new SPStage();
			
			int moved = 0;
			int touched = 0;
			
			SPEventHandler movedHandler = delegate(SPEventDispatcher source, SPEventArgs e) {
				moved++;
			};
			
			SPEventHandler touchedHandler = delegate(SPEventDispatcher source, SPEventArgs e) {
				touched++;
			};
			
			dispatcher.AddEventListener("moved", movedHandler);
			dispatcher.AddEventListener("touched", touchedHandler);
			
			dispatcher.DispatchEvent(new SPEvent("moved"));
			dispatcher.DispatchEvent(new SPEvent("touched"));
			dispatcher.DispatchEvent(new SPEvent("moved"));
			
			Assert.True(moved == 2);
			Assert.True(touched == 1);
			
			// can't add same handler again, this will be ignored
			dispatcher.AddEventListener("touched", touchedHandler);
			
			dispatcher.DispatchEvent(new SPEvent("touched"));
			
			Assert.True(touched == 2);
			
			dispatcher.RemoveEventListener("touched", touchedHandler);
			
			dispatcher.DispatchEvent(new SPEvent("touched"));
			
			Assert.True(touched == 2);
			
			dispatcher.RemoveEventListener("moved", touchedHandler);
			
			// DUMMY TEST
			SPEventArgs xxx = new SPEvent("xxx", true);
			
			Assert.False(xxx.Cancel);
			Assert.True(xxx.Bubbles);
			
			xxx.Bubbles = false;
			xxx.Cancel = true;
			
			Assert.True(xxx.Cancel);
			Assert.False(xxx.Bubbles);
			
			#endregion
		}
	}
}
