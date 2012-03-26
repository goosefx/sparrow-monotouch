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
			
			// should be ignored
			dispatcher.AddEventListener("touched", touchedHandler);
			
			Assert.True(dispatcher.GetInvocationList().Length == 2);
			Assert.True(dispatcher.GetInvocationList()[0].GetEventTypes().Length == 1);
			Assert.True(dispatcher.GetInvocationList()[1].GetEventTypes().Length == 1);

			dispatcher.DispatchEvent(new SPEvent("touched"));
			
			Assert.True(touched == 2);
			
			dispatcher.RemoveEventListener("touched", touchedHandler);
			
			dispatcher.DispatchEvent(new SPEvent("touched"));
			
			Assert.True(touched == 2);
			
			dispatcher.RemoveEventListener("moved", movedHandler);
			
			Assert.True(dispatcher.GetInvocationList() == null);
			
			#endregion
		}
		
		[Test]
		public void ManagedEvents()
		{
			#region ...
			
			bool onStage = false;
			bool added = false;
			bool custom = false;
			
			SPStage stage = new SPStage();
			
			SPQuad obj = new SPQuad(16.0f, 16.0f);
			
			obj.Added += delegate(SPEventDispatcher source, SPEventArgs e) {
				added = true;	
			};
			
			obj.AddedToStage += delegate(SPEventDispatcher source, SPEventArgs e) {
				onStage = true;	
			};
			
			obj.Removed += delegate(SPEventDispatcher source, SPEventArgs e) {
				added = false;	
			};
			
			obj.RemovedFromStage += delegate(SPEventDispatcher source, SPEventArgs e) {
				onStage = false;	
			};
			
			obj.AddEventListener("custom", (SPEventHandler)delegate(SPEventDispatcher source, SPEventArgs e) {
				custom = true;	
			});
			
			obj.DispatchEvent(new SPEvent("custom"));
	
			Assert.True(custom);
			
			stage.Add(obj);
			
			Assert.True(added);
			Assert.True(onStage);
			
			stage.Remove(obj);
			
			Assert.False(added);
			Assert.False(onStage);
			
			#endregion
		}
	}
}
