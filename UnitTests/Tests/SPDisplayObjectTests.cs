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
		[Ignore ("SPRectangle not implemented yet!")]
        public void Bounds()
		{
			#region ...
			
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
		[Ignore ("SPMatrix not implemented yet!")]
		public void TransformationMatrix()
		{
			#region ...
			
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

			#endregion
		}
		
		
		[Test]
		[Ignore ("SPMatrix not implemented yet!")]
		public void TransformationMatrixToSpace()
		{
			#region ...

			#endregion
		}
		
		[Test]
		[Ignore ("SPRectangle not implemented yet!")]
		public void BoundsInSpace()
		{
			#region ...

			#endregion
		}
		
		[Test]
		[Ignore ("SPPoint not implemented yet!")]
		public void LocalToGlobal()
		{
			#region ...

			#endregion
		}
		
		[Test]
		[Ignore ("SPPoint not implemented yet!")]
		public void GlobalToLocal()
		{
			#region ...

			#endregion
		}
		
		[Test]
		[Ignore ("SPPoint not implemented yet!")]
		public void HitTestPoint()
		{
			#region ...

			#endregion
		}
		
		[Test]
		[Ignore ("SPEvent not implemented yet!")]
		public void BroadcastEvent()
		{
			#region ...

			#endregion
		}
		
	}
}
