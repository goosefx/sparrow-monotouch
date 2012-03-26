using System;
using NUnit.Framework;
using MonoTouch.Foundation;
using Sparrow;

namespace UnitTests
{
	[TestFixture]
    public class SPDisplayObjectTests
	{
		[Test]
		public void CoordinantesAndAlpha()
		{
			#region ...
			
			SPDisplayObject obj = new SPQuad(32.0f, 32.0f);
			
			obj.X = 1.0f;
			obj.Y = 2.0f;
			obj.PivotX = 16.0f;
			obj.PivotY = 8.0f;
			obj.ScaleX = 2.0f;
			obj.ScaleY = 0.5f;
			
			Assert.True(obj.X == 1.0f);
			Assert.True(obj.Y == 2.0f);
			Assert.True(obj.PivotX == 16.0f);
			Assert.True(obj.PivotY == 8.0f);
			Assert.True(obj.ScaleX == 2.0f);
			Assert.True(obj.ScaleY == 0.5f);
			
			Assert.True(obj.Width == 64.0f); // ScaleX = 2.0f
			Assert.True(obj.Height == 16.0f); // ScaleY = 0.5f
			
			obj.Width = 128.0f;
			obj.Height = 32.0f;
			
			Assert.True(obj.Width == 128.0f);
			Assert.True(obj.Height == 32.0f);
	
			Assert.True(obj.ScaleX == 4.0f);
			Assert.True(obj.ScaleY == 1.0f);
			
			float degree45 = (float)(Math.PI * 45.0 / 180.0);
			obj.Rotation = degree45;
			
			Assert.True(obj.Rotation == degree45);
			Assert.True(obj.Alpha == 1.0f);
			
			obj.Alpha = 0.5f;
			
			Assert.True(obj.Alpha == 0.5f);
			
			#endregion
		}
		
		[Test]
		public void VisibleAndTouchable()
		{
			#region ...
			
			SPDisplayObject obj = new SPQuad(32.0f, 32.0f);
			
			Assert.True(obj.Visible == true);
			Assert.True(obj.Touchable == true);
			
			obj.Visible = false;
			
			Assert.True(obj.Visible == false);
			Assert.True(obj.Touchable == true);
			
			obj.Visible = true;
			obj.Touchable = false;
			
			Assert.True(obj.Visible == true);
			Assert.True(obj.Touchable == false);
			
			#endregion
		}
		
		[Test]
		public void Bounds()
		{
			#region ...
				
			SPDisplayObject obj = new SPQuad(16.0f, 32.0f);
			obj.X = 4.0f;
			obj.Y = 8.0f;
			
			Assert.True(obj.Bounds == new SPRectangle(4.0f, 8.0f, 16.0f, 32.0f));
			
			#endregion
		}
		
		[Test]
		public void Parent()
		{
			#region ...
			
			SPStage parent = new SPStage();
			SPDisplayObject obj = new SPQuad(32.0f, 32.0f);
			
			Assert.Null(obj.Parent);
			
			parent.Add(obj);
			
			Assert.True(obj.Parent == parent);
			
			#endregion
		}
		
		[Test]
		public void Root()
		{
			#region ...
			
			SPStage root = new SPStage();
			SPStage parent = new SPStage();
			SPDisplayObject obj = new SPQuad(32.0f, 32.0f);
			
			Assert.True(obj.Root == obj);
			
			parent.Add(obj);
			root.Add(parent);
			
			Assert.True(obj.Root == root);
			
			#endregion
		}

		
		[Test]
		public void Stage()
		{
			#region ...
			
			SPStage root = new SPStage();
			SPStage parent = new SPStage();
			SPDisplayObject obj = new SPQuad(32.0f, 32.0f);
			
			parent.Add(obj);
			root.Add(parent);
			
			Assert.True(obj.Stage == root);
			
			#endregion
		}
		
		[Test]
		public void TransformationMatrix()
		{
			#region ...
			
			SPDisplayObject obj = new SPQuad(16.0f, 32.0f);
			
			SPMatrix m = obj.TransformationMatrix;
			
			Assert.NotNull(m);
			
			#endregion
		}
		
		[Test]
		public void Name()
		{
			#region ...
			
			SPStage parent = new SPStage();
			SPDisplayObject obj = new SPQuad(32.0f, 32.0f);
			
			Assert.Null(obj.Name);
			obj.Name = "TestObject";
			
			Assert.True(obj.Name == "TestObject");
				
			parent.Add(obj);
			
			Assert.True(parent["TestObject"] == obj);
			
			
			#endregion
		}
		
		[Test]
		[Ignore ("SPRenderSupport not implemented yet!")]
		public void Render()
		{
			#region ...

			#endregion
		}
		
		
		[Test]
		public void RemoveFromParent()
		{
			#region ...
			
			SPStage parent = new SPStage();
			SPDisplayObject child = new SPQuad();
			
			parent.Add(child);
			
			Assert.NotNull(child.Parent);
			
			child.RemoveFromParent();
			
			Assert.Null(child.Parent);
			
			#endregion
		}
		
		
		[Test]
		public void TransformationMatrixToSpace()
		{
			#region ...
			
			SPStage stage = new SPStage();
			SPDisplayObject obj = new SPQuad();
			
			stage.Add(obj);
			SPMatrix m = obj.TransformationMatrixToSpace(stage);
			
			Assert.NotNull(m);
			
			#endregion
		}
		
		[Test]
		public void BoundsInSpace()
		{
			#region ...
	
			SPStage stage = new SPStage();
			SPDisplayObject obj = new SPQuad();
			
			stage.Add(obj);
	
			SPRectangle b = obj.BoundsInSpace(stage);
			
			Assert.NotNull(b);
			
			#endregion
		}
		
		[Test]
		public void LocalToGlobal()
		{
			#region ...
			
			SPStage stage = new SPStage();
			SPDisplayObject obj = new SPQuad();
			SPPoint p1 = new SPPoint(5.0f, 5.0f);
			
			stage.Add(obj);
	
			SPPoint p2 = obj.LocalToGlobal(p1);
			
			Assert.NotNull(p2);
			
			#endregion
		}
		
		[Test]
		public void GlobalToLocal()
		{
			#region ...

			
			SPStage stage = new SPStage();
			SPDisplayObject obj = new SPQuad();
			SPPoint p1 = new SPPoint(5.0f, 5.0f);
			
			stage.Add(obj);
	
			SPPoint p2 = obj.GlobalToLocal(p1);
			
			Assert.NotNull(p2);

			#endregion
		}
		
		[Test]
		public void HitTestPoint()
		{
			#region ...
			
			SPStage stage = new SPStage();
			SPDisplayObject obj1 = new SPQuad();
			SPPoint p1 = new SPPoint(5.0f, 5.0f);
			
			stage.Add(obj1);
			
			SPDisplayObject obj2 = stage.HitTest(p1, true);
			
			Assert.NotNull(obj2);
			
			#endregion
		}
		
		[Test]
		public void BroadcastEvent()
		{
			#region ...
			
			bool myEventReceived = false;
			SPStage stage = new SPStage();
			SPDisplayObject obj1 = new SPQuad();
			
			stage.Add(obj1);
			
			obj1.AddEventListener("myEvent", (SPEventHandler)delegate(SPEventDispatcher source, SPEventArgs e) {
				myEventReceived = true;
			});
			
			stage.BroadcastEvent(new SPEvent("myEvent"));
			
			Assert.True(myEventReceived);
			
			#endregion
		}
		
	}
}
