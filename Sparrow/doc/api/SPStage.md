[Sparrow Framework 1.3 MonoTouch Documentation](../index.md) 
# SPStage

    public class SPStage : SPDisplayObjectContainer
  
An SPStage is the root of the display tree. It represents the rendering area of the application.
 
To create a Sparrow application, you create a class that inherits from SPStage and populates the display tree.
 
The stage allows you to access the native view object it is drawing its content to. (Currently, this is always an SPView). Furthermore, you can change the framerate in which the contents is rendered.
 
You can access the stage from anywhere in your code:

    SPStage.MainStage
 
A stage also contains a default juggler which you can use for your animations. It is advanced automatically once per frame. You can access this juggler from any display object by calling:
 
    SPStage.MainStage.Juggler

## Properties

 - `FrameRate` : The requested number of frames per second. Must be a divisor of 60 (like 30, 20, 15, 12, 10, etc.). The actual frame rate might be lower if there is too much to process.
 - `Color` : The background [color](SPColor.md) of the stage. Default: black (0x000000).
 - `Juggler`: A [juggler](SPJuggler.md) that is automatically advanced once per frame. *(readonly)*
 - `NativeView` : The native [view](SPView.md) the stage is connected to. *(readonly)*

## Static Properties

 - `MainStage` : Returns the first available stage instance. (In most cases, there is only one stage, anyway.) *(readonly)*
 - `ContentScaleFactor` : The current content scale factor. *(readonly)*
 - `SupportHighResolutions` : Enables support for high resolutions (aka retina displays).
 - `DoubleResolutionsOnPad` : Determines if pad devices use twice the resolution. If both SupportHighResolutions and DoubleResolutionsOnPad is set to `true`, pad devices will use twice the resolution ('@2x' on iPad 1+2, '@4x' on iPad 3+)

## Constructors

    new SPStage(float width, float height)
  
Initializes a stage with a certain size in points.

    new SPStage()
  
Initializes a fullscreen stage.

## Methods

    void AdvanceTime(double seconds);

Dispatches an enter frame event on all children and advances the [juggler](SPJuggler.md).

    void ProcessTouches(NSSet touches);

Process a new set up touches. Dispatches touch events on affected children.

---

**See Also:**

 - [SPEventDispatcher](SPEventDispatcher.md)
 - [SPDisplayObject](SPDisplayObject.md)
 - [SPDisplayObjectContainer](SPDisplayObjectContainer.md)