using System;
using System.Drawing;

using MonoTouch.ObjCRuntime;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using MonoTouch.CoreGraphics;
using MonoTouch.AVFoundation;

// Version 1.3
namespace Sparrow
{
	#region Protocol SPAnimatable (DONE)
	
	/// <summary>
	/// The SPAnimatable protocol describes objects that are animated depending on the passed time. 
	/// Any object that implements this protocol can be added to the SPJuggler.
	/// </summary>
	[BaseType (typeof(NSObject))]
	[Model]
	public interface SPAnimatable
	{
		/// <summary>
		/// Indicates if the animation is finished. (The juggler will purge the object.)
		/// </summary>
		[Export("isComplete")]
		bool IsComplete
		{
			get;
		}
		
		/// <summary>
		/// Advance the animation by a number of seconds.
		/// </summary>
		[Export("advanceTime:")]
		void AdvanceTime(double seconds);
	}
	#endregion
	
	#region SPNSExtensions (TODO) 
	#endregion

	#region SPEventDispatcher (TODO) 
	[Abstract]
	[BaseType (typeof(NSObject))]
	public interface SPEventDispatcher
	{
		
	}
	#endregion
	
	#region SPDisplayObject (TODO) 
	[Abstract]
	[BaseType (typeof(SPEventDispatcher))]
	public interface SPDisplayObject
	{
		
	}
	#endregion
	
	#region SPDisplayObjectContainer (DONE)
	
	/// <summary>
	/// Compares two display objects.
	/// </summary>
	public delegate int SPDisplayObjectComparator(SPDisplayObject obj1, SPDisplayObject obj2);
	
	/// <summary>
	/// An SPDisplayObjectContainer represents a collection of display objects.
 	/// </summary>
 	/// <remarks>
 	/// It is the base class of all display objects that act as a container for other objects. By 
 	/// maintaining an ordered list of children, it defines the back-to-front positioning of the children
 	/// within the display tree.
 	/// 
 	/// A container does not have size in itself. The width and height properties represent the extents
 	/// of its children. Changing those properties will scale all children accordingly.
 	/// 
 	/// As this is an abstract class, you can't instantiate it directly, but have to 
	/// use a subclass instead. The most lightweight container class is SPSprite.
	/// </remarks>
	[Abstract]
	[BaseType (typeof(SPDisplayObject))]
	public interface SPDisplayObjectContainer
	{
		#region Properties
		
		/// <summary>
		/// The number of children of this container.
		/// </summary>
		[Export("numChildren")]
		int Count
		{
			get;
		}
		
		#endregion

		#region Methods
		
		/// <summary>
		/// Adds a child to the container. It will be at the topmost position.
		/// </summary>
		[Export("addChild:")]
		void Add(SPDisplayObject child);
		
		[Internal]
		[Export("addChild:atIndex:")]
		void InternalAddAtIndex(SPDisplayObject child, int index);
		
		/// <summary>
		/// Determines if a certain object is a child of the container (recursively).
		/// </summary>
		[Export("containsChild:")]
		bool Contains(SPDisplayObject child);
		
		[Internal]
		[Export("childAtIndex:")]
		SPDisplayObject InternalChildAtIndex(int index);
		
		[Internal]
		[Export("childByName:")]
		SPDisplayObject InternalChildByName(string name);
		
		/// <summary>
		/// Returns the index of a child within the container.
		/// </summary>
		[Export("childIndex:")]
		int IndexOf(SPDisplayObject child);
		
		/// <summary>
		/// Moves a child to a certain index. Children at and after the replaced position move up.
		/// </summary>
		[Export("setIndex:ofChild:")]
		void SetIndex(int index, SPDisplayObject child);
		
		[Internal]
		[Export("removeChild:")]
		void InternalRemove(SPDisplayObject child);
		
		/// <summary>
		/// Removes a child at a certain index. Children above the child will move down.
		/// </summary>
		[Export("removeChildAtIndex:")]
		void RemoveAt(int index);
		
		/// <summary>
		/// Removes all children from the container.
		/// </summary>
		[Export("removeAllChildren:")]
		void Clear();
		
		/// <summary>
		/// Swaps the indexes of two children.
		/// </summary>
		[Export("swapChild:withChild:")]
		void Swap(SPDisplayObject child1, SPDisplayObject child2);
		
		/// <summary>
		/// Swaps the indexes of two children.
		/// </summary>
		[Export("swapChildAtIndex:withChildAtIndex:")]
		void Swap(int index1, int index2);
		
		/// <summary>
		/// Sorts the children using the given comparison. Only available in iOS 4 and above!
		/// </summary>
		[Export("sortChildren:")]
		void Sort(SPDisplayObjectComparator comparator);
		
		/// <summary>
		/// Dispatches an event on all children (recursively). The event must not bubble.
		/// </summary>
		[Export("broadcastEvent:")]
		void BroadcastEvent(SPEvent event_);
		
		#endregion
	}
	#endregion
	
	#region SPQuad (TODO) 
	#endregion
	
	#region SPImage (TODO) 
	#endregion
	
	#region SPTextField (TODO) 
	#endregion

	#region SPBitmapFont (TODO) 
	#endregion
	
	#region SPButton (TODO) 
	#endregion
	
	#region SPStage (DONE)
	/// <summary>
	/// An SPStage is the root of the display tree. It represents the rendering area of the application.
	/// </summary>
	/// <remarks>
	/// To create a Sparrow application, you create a class that inherits from SPStage and populates
	/// the display tree.
	/// 
	/// The stage allows you to access the native view object it is drawing its content to. (Currently,
	/// this is always an SPView). Furthermore, you can change the framerate in which the contents is 
	/// rendered.
	/// 
	/// You can access the stage from anywhere in your code with the following static method:
	/// 
	/// 	SPStage.MainStage
	/// 	 
	/// A stage also contains a default juggler which you can use for your animations. It is advanced 
	/// automatically once per frame. You can access this juggler from any display object by calling:
	/// 
	/// 	SPStage.MainStage.Juggler
	/// 
	/// </remarks>
	[BaseType (typeof(SPDisplayObjectContainer))]
	public interface SPStage
	{
		#region Static
		
		/// <summary>
		/// Returns the first available stage instance. (In most cases, there is only one stage, anyway.)
		/// </summary>
		[Static]
		[Export("mainStage")]
		SPStage MainStage
		{
			get;
		}
		
		/// <summary>
		/// Enables support for high resolutions (aka retina displays).
		/// </summary>
		[Static]
		[Export("supportHighResolutions")]
		bool SupportHighResolutions
		{
			get;
			set;
		}
		
		/// <summary>
		/// Determines if pad devices use twice the resolution.
		/// </summary>
		[Static]
		[Export("doubleResolutionsOnPad")]
		bool DoubleResolutionsOnPad
		{
			get;
		}
		
		/// <summary>
		/// The current content scale factor.
		/// </summary>
		[Static]
		[Export("contentScaleFactor")]
		float ContentScaleFactor
		{
			get;
		}
		
		/// <summary>
		/// Enables support for high resolutions (aka retina displays). If 'doubleOnPad' is true, 
		/// pad devices will use twice the resolution ('@2x' on iPad 1+2, '@4x' on iPad 3+).
		/// </summary>
		[Static]
		[Export("setSupportHighResolutions")]
		void SetSupportHighResolutions(bool hd, bool doubleOnPad);
		
		#endregion
		
		#region Properties
		
		/// <summary>
		/// The requested number of frames per second. Must be a divisor of 60 (like 30, 20, 15, 12, 10, etc.).
		/// The actual frame rate might be lower if there is too much to process.
		/// </summary>
		[Export("frameRate", ArgumentSemantic.Assign)]
		float FrameRate
		{
			get;
			set;
		}
		
		/// <summary>
		/// The background color of the stage. Default: black (0x000000).
		/// </summary>
		[Export("color", ArgumentSemantic.Assign)]
		uint Color
		{
			get;
			set;
		}
		
		/// <summary>
		/// A juggler that is automatically advanced once per frame.
		/// </summary>
		[Export("juggler")]
		SPJuggler Juggler
		{
			get;
		}
		
		/// <summary>
		/// The native view the stage is connected to.
		/// </summary>
		[Export("nativeView")]
		SPView NativeView
		{
			get;
		}
		
		#endregion
		
		#region Constructors
		
		/// <summary>
		/// Initializes a stage with a certain size in points.
		/// </summary>
		[Export("initWithWidth:height:")]
		IntPtr Constructor(float width, float height);
		
		#endregion
		
		#region Methods

		/// <summary>
		/// Dispatches an enter frame event on all children and advances the juggler.
		/// </summary>
		[Export("advanceTime:")]
		void AdvanceTime(double seconds);

		
		/// <summary>
		/// Process a new set up touches. Dispatches touch events on affected children.
		/// </summary>
		[Export("processTouches:")]
		void ProcessTouches(NSSet touches);
		
		#endregion
	}
	#endregion
	
	#region SPSprite (TODO) 
	#endregion
	
	#region SPCompiledSprite (TODO) 
	#endregion
	
	#region SPMovieClip (TODO) 
	#endregion
	
	#region SPTexture (TODO) 
	#endregion
	
	#region SPSubTexture (TODO) 
	#endregion
	
	#region SPRenderTexture (TODO) 
	#endregion
	
	#region SPGLTexture (TODO) 
	#endregion
	
	#region SPTextureAtlas (TODO) 
	#endregion
	
	#region SPEvent (TODO)
	[BaseType(typeof(NSObject))]
	public interface SPEvent
	{
		
	}
	#endregion
	
	#region SPTouchEvent (TODO) 
	#endregion
	
	#region SPEnterFrameEvent (TODO) 
	#endregion
	
	#region SPJuggler (TODO)
	[BaseType(typeof(NSObject))]
	public interface SPJuggler //: SPAnimatable
	{
		
	}
	#endregion
	
	#region SPTransitions (TODO) 
	#endregion
	
	#region SPTween (TODO) 
	#endregion
	
	#region SPDelayedInvocation (TODO) 
	#endregion
	
	#region SPRectangle (TODO) 
	#endregion
	
	#region SPMacros (TODO) 
	#endregion
	
	#region SPUtils (TODO) 
	#endregion
	
	#region SPView (DONE)
	/// <summary>
	/// An SPView is the UIView object that Sparrow renders its content into. 
	/// </summary>
	/// <remarks>
	/// Add it to the UIKit display list like any other view. Beware that Sparrow will only receive
	/// multitouch events if the `multitouchEnabled` property of the view is enabled.
	/// 
	/// To start Sparrow, connect this class to your stage subclass and call the `start` method. When
	/// the application ends or moves into the background, you should call the `stop` method.
	/// </remarks>
	
	[BaseType(typeof(UIView))]
	public interface SPView
	{
		#region Properties
		
		[Export("isStarted")]
		bool IsStarted
		{ 
			get;
		}
		
		/// <summary>
		/// Assigns the desired framerate. Only dividers of 60 are allowed (60, 30, 20, 15, 12, 10, etc.)
		/// </summary>
		[Export("frameRate", ArgumentSemantic.Assign)]
		float FrameRate
		{
			get;
			set;
		}
		
		/// <summary>
		/// The stage object that will be processed.
		/// </summary>
		[Export("stage", ArgumentSemantic.Retain)]
		SPStage Stage
		{
			get;
			set;
		}

		#endregion

		#region Constructors
		
		[Export("initWithFrame:")]
		IntPtr Constructor(RectangleF frame);
		
		#endregion
		
		#region Methods
		
		/// <summary>
		/// Starts rendering and event handling.
		/// </summary>
		[Export ("start")]
		void Start();

		/// <summary>
		/// Stops rendering and event handling. Call this when the application moves into the background.
		/// </summary>
		[Export ("stop")]
		void Stop();
		
		#endregion
	}
	#endregion
	
	#region SPRenderSupport (TODO) 
	#endregion
	
	#region SPAudioEngine (TODO) 
	#endregion
	
	#region SPSound (TODO) 
	#endregion
	
	#region SPSoundChannel (TODO) 
	#endregion

}

