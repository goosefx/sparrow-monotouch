[Sparrow Framework 1.3 MonoTouch Documentation](../index.md) 
# SPView
	
	public class SPView : UIView

An SPView is the [UIView](http://iosapi.xamarin.com/monodoc.ashx?link=T:MonoTouch.UIKit.UIView) object that Sparrow renders its content into. 
 
Add it to the UIKit display list like any other view. Beware that Sparrow will only receive multitouch events if the `MultipleTouchEnabled` property of the view is enabled.
 
To start Sparrow, connect this class to your stage subclass and call the `Start` method. When the application ends or moves into the background, you should call the `Stop` method.

## Properties

 - `IsStarted` : Indicates if start was called. *(readonly)*
 - `FrameRate` : Assigns the desired framerate. Only dividers of 60 are allowed (60, 30, 20, 15, 12, 10, etc.)
 - `Stage` : The [stage](SPStage.md) object that will be processed.
 
## Constructors

See [UIView](http://iosapi.xamarin.com/monodoc.ashx?link=T:MonoTouch.UIKit.UIView) documentation for details.

## Methods
		
	void Start();

Starts rendering and event handling.

	void Stop();

Stops rendering and event handling. Call this when the application moves into the background.

---

**See Also:**

 - [UIView](http://iosapi.xamarin.com/monodoc.ashx?link=T:MonoTouch.UIKit.UIView)
 - [SPStage](SPStage.md)