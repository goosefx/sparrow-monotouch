using System;
using System.Drawing;
using System.Collections.Generic;

using MonoTouch.Foundation;
using MonoTouch.UIKit;

using Sparrow;
using System.Diagnostics;

namespace HelloWorld
{
	// The UIApplicationDelegate for the application. This class is responsible for launching the 
	// User Interface of the application, as well as listening (and optionally responding) to 
	// application events from iOS.
	[Register ("AppDelegate")]
	public partial class AppDelegate : UIApplicationDelegate
	{
		// class-level declarations
		private UIWindow window;
		private UIViewController rootViewController;
		private SPView sparrowView;
		
		//
		// This method is invoked when the application has loaded and is ready to run. In this 
		// method you should instantiate the window, load the UI into it and then make the window
		// visible.
		//
		// You have 17 seconds to return from this method, or iOS will terminate your application.
		//
		public override bool FinishedLaunching(UIApplication app, NSDictionary options)
		{
			Console.WriteLine("finished loading");
			
			RectangleF frame = UIScreen.MainScreen.Bounds;
			
			// create a new window instance based on the screen size
			window = new UIWindow(frame);
			
			//SPAudioEngine.StartWithCategory(Sparrow.SPAudioSessionCategory.AmbientSound);
			SPStage.SupportHighResolutions = true; // use @2x textures on suitable hardware
			SPStage.DoubleResolutionsOnPad = true; // use @2x on iPad 1+2, @4x on iPad 3
			
			// create sparrow view
			sparrowView = new SPView(frame);
			sparrowView.MultipleTouchEnabled = true;
			sparrowView.FrameRate = 30;
			
			// create a root view controller
			rootViewController = new UIViewController();
			rootViewController.View = sparrowView;
			
			// set root view controller
			window.RootViewController = rootViewController;
			
			// create a stage
			SPStage stage = new SPStage(frame.Size.Width, frame.Size.Height);
			stage.Color = 0x2000a0;
			sparrowView.Stage = stage;
			
			// create and add our hello world text field to the stage
			SPTextField text = new SPTextField(frame.Size.Width, 50.0f, "Hello World!", "Helvetica", 30.0f, SPColor.White);
			text.Y = (frame.Size.Height - 50.0f) / 2.0f; // vertical center
			stage.Add(text);
			
			// make the window visible
			window.MakeKeyAndVisible();
			
			return true;
		}
		
		public override void OnActivated(UIApplication application)
		{
			sparrowView.Start();
		}

		public override void OnResignActivation(UIApplication application)
		{
			sparrowView.Stop();
		}

		public override void ReceiveMemoryWarning(UIApplication application)
		{
			SPPoint.PurgePool();
			SPRectangle.PurgePool();
			SPMatrix.PurgePool();
		}
	}
}

