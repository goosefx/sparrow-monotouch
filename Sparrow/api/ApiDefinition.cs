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
	#region SPPoolInfo (DONE)

	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	public interface SPPoolInfo
	{
		[Export("init")]
		IntPtr Constructor();
	}

	#endregion
	
	#region SPPoolObject (DONE)
	
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	public interface SPPoolObject
	{
		[Export("init")]
		IntPtr Constructor();
	}
	
	#endregion
	
	#region SPPoint (DONE)
	
	[BaseType (typeof(SPPoolObject))]
	[DisableDefaultCtor]
	public interface SPPoint
	{
		#region Static
		
		[Static, Export("pointWithPolarLength:angle:")]
		SPPoint FromPolarLength(float length, float angle);
		
		[Static, Export("distanceFromPoint:toPoint:")]
		float CalculateDistance(SPPoint p1, SPPoint p2);

		[Static, Export("angleBetweenPoint:andPoint:")]
		float CalculateAngle(SPPoint p1, SPPoint p2);
		
		[Static, Export("interpolateFromPoint:toPoint:ratio:")]
		SPPoint Interpolate(SPPoint p1, SPPoint p2, float ratio);

		[Static, Export("purgePool")]
		int PurgePool();

		#endregion
		
		#region Properties
		
		[Export("x", ArgumentSemantic.Assign)]
		float X
		{
			get;
			set; 
		}
		
		[Export("y", ArgumentSemantic.Assign)]
		float Y
		{
			get;
			set; 
		}
		
		[Export("length", ArgumentSemantic.Assign)]
		float Length
		{
			get;
		}
		
		[Export("lengthSquared")]
		float LengthSquared
		{
			get;
		}
		
		[Export("angle")]
		float Angle
		{
			get;
		}
		
		[Export("isOrigin")]
		bool IsOrigin
		{
			get;
		}
			
		#endregion
		
		#region Constructors
		
		[Export ("initWithX:y:")]
		IntPtr Constructor(float x, float y);

		#endregion
		
		#region Methods
		
		[Internal]
		[Export("addPoint:")]
		SPPoint _AddPoint(SPPoint point);
		
		[Internal]
		[Export("subtractPoint:")]
		SPPoint _SubtractPoint(SPPoint point);
		
		[Export("scaleBy:")]
		SPPoint Scale(float scalar);
		
		[Export("rotateBy:")]
		SPPoint Rotate(float angle);
		
		[Export("normalize")]
		SPPoint Normalize();
		
		[Export("invert")]
		SPPoint Invert();
		
		[Export("dot:")]
		float Dot(SPPoint other);
		
		[Internal]
		[Export("isEqual:")]
		bool _IsEqual(NSObject other);
		
		#endregion
	}
	
	#endregion
	
	#region SPRectangle (DONE)
	
	[BaseType (typeof(SPPoolObject))]
	[DisableDefaultCtor]
	public interface SPRectangle
	{
		#region Static
		
		[Static, Export("purgePool")]
		int PurgePool();

		#endregion
		
		#region Properties
		
		[Export("x", ArgumentSemantic.Assign)]
		float X
		{
			get;
			set;
		}
		
		[Export("y", ArgumentSemantic.Assign)]
		float Y
		{
			get;
			set;
		}
		
		[Export("width", ArgumentSemantic.Assign)]
		float Width
		{
			get;
			set;
		}
		
		[Export("height", ArgumentSemantic.Assign)]
		float Height
		{
			get;
			set;
		}
		
		[Export("top", ArgumentSemantic.Assign)]
		float Top
		{
			get;
			set;
		}
		
		[Export("bottom", ArgumentSemantic.Assign)]
		float Bottom
		{
			get;
			set;
		}
		
		[Export("left", ArgumentSemantic.Assign)]
		float Left
		{
			get;
			set;
		}
		
		[Export("right", ArgumentSemantic.Assign)]
		float Right
		{
			get;
			set;
		}
		
		[Export("topLeft", ArgumentSemantic.Copy)]
		SPPoint TopLeft
		{
			get;
			set;
		}
		
		[Export("topLeft", ArgumentSemantic.Copy)]
		SPPoint Location
		{
			get;
			set;
		}
		
		[Export("bottomRight", ArgumentSemantic.Copy)]
		SPPoint BottomRight
		{
			get;
			set;
		}
		
		[Export("size", ArgumentSemantic.Copy)]
		SPPoint Size
		{
			get;
			set;
		}
		
		[Export("isEmpty")]
		bool IsEmpty
		{
			get;
		}
		
		#endregion
		
		#region Constructors
		
		[Export("initWithX:y:width:height:")]
		IntPtr Constructor(float x, float y, float width, float height);
		
		#endregion
	
		#region Methods
		
		[Export("containsX:y:")]
		bool Contains(float x, float y);
		
		[Export("containsPoint:")]
		bool Contains(SPPoint point);
		
		[Export("containsRectangle:")]
		bool Contains(SPRectangle rectangle);
		
		[Export("intersectsRectangle:")]
		bool IntersectsWith(SPRectangle rectangle);
		
		[Export("intersectionWithRectangle:")]
		SPRectangle Intersect(SPRectangle rectangle);
		
		[Export("uniteWithRectangle:")]
		SPRectangle Union(SPRectangle rectangle);	
		
		[Export("setEmpty")]
		void SetEmpty();
		
		#endregion
	}
	
	#endregion
	
	#region SPMatrix (DONE)
	
	[BaseType (typeof(SPPoolObject))]
	[DisableDefaultCtor]
	public interface SPMatrix
	{
		#region Static
		
		[Static, Export("purgePool")]
		int PurgePool();

		#endregion
		
		#region Properties
		
		[Export("a", ArgumentSemantic.Assign)]
		float A
		{
			get;
			set;
		}
		
		[Export("b", ArgumentSemantic.Assign)]
		float B
		{
			get;
			set;
		}
		
		[Export("c", ArgumentSemantic.Assign)]
		float C
		{
			get;
			set;
		}
		
		[Export("d", ArgumentSemantic.Assign)]
		float D
		{
			get;
			set;
		}
		
		[Export("tx", ArgumentSemantic.Assign)]
		float Tx
		{
			get;
			set;
		}
		
		[Export("ty", ArgumentSemantic.Assign)]
		float Ty
		{
			get;
			set;
		}
		
		[Export("determinant")]
		float Determinant
		{
			get;
		}
		
		#endregion
		
		#region Constructors
		
		[Export("initWithA:b:c:d:tx:ty:")]
		IntPtr Constructor(float a, float b, float c, float d, float tx, float ty);
		
		[Export("init")]
		IntPtr Constructor();
		
		#endregion
	
		#region Methods

		[Export("setA:b:c:d:tx:ty:")]
		void Set(float a, float b, float c, float d, float tx, float ty);
			
		[Internal, Export("isEqual:")]
		bool _IsEqual(NSObject other);
		
		[Export("concatMatrix:")]
		void Concat(SPMatrix matrix);
		
		[Export("translateXBy:yBy:")]
		void Translate(float dx, float dy);
		
		[Export("scaleXBy:yBy:")]
		void Scale(float sx, float sy);
		
		[Export("scaleBy:")]
		void Scale(float scale);
		
		[Export("rotateBy:")]
		void Rotate(float angle);
		
		[Export("identity")]
		void SetIdentity();

		[Export("invert")]
		void Invert();
		
		[Export("transformPoint:")]
		SPPoint Transform(SPPoint point);
		
		#endregion
	}
	
	#endregion
	
	#region SPEventDispatcher (DONE) 
	
	[Abstract]
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	public interface SPEventDispatcher
	{
		#region Methods
		
		[Internal, Export("addEventListener:atObject:forType:retainObject:")]
		void _AddEventListener(Selector listener, NSObject object_, string eventType, bool retain);
		
		[Internal, Export("addEventListener:atObject:forType:")]
		void _AddEventListener(Selector listener, NSObject object_, string eventType);
		
		[Internal, Export("removeEventListener:atObject:forType:")]
		void _RemoveEventListener(Selector listener, NSObject object_, string eventType);
		
		// (not required)
		//- (void)removeEventListenersAtObject:(id)object forType:(NSString*)eventType;
		
		[Export("dispatchEvent:")]
		void DispatchEvent(SPEvent event_);
		
		[Export("hasEventListenerForType:")]
		void HasEventListener(string eventType);
		
		#endregion
	}
	#endregion
	
	#region SPDisplayObject (DONE) 
	
	[Abstract]
	[BaseType (typeof(SPEventDispatcher))]
	[DisableDefaultCtor]
	public interface SPDisplayObject
	{
		#region Properties
		
		[Export("x", ArgumentSemantic.Assign)]
		float X
		{
			get;
			set;
		}
		
		[Export("y", ArgumentSemantic.Assign)]
		float Y
		{
			get;
			set;
		}
		
		[Export("pivotX", ArgumentSemantic.Assign)]
		float PivotX
		{
			get;
			set;
		}
		
		[Export("pivotY", ArgumentSemantic.Assign)]
		float PivotY
		{
			get;
			set;
		}
		
		[Export("scaleX", ArgumentSemantic.Assign)]
		float ScaleX
		{
			get;
			set;
		}
	
		[Export("scaleY", ArgumentSemantic.Assign)]
		float ScaleY
		{
			get;
			set;
		}
		
		[Export("width", ArgumentSemantic.Assign)]
		float Width
		{
			get;
			set;
		}
		
		[Export("height", ArgumentSemantic.Assign)]
		float Height
		{
			get;
			set;
		}
		
		[Export("rotation", ArgumentSemantic.Assign)]
		float Rotation
		{
			get;
			set;
		}
		
		[Export("alpha", ArgumentSemantic.Assign)]
		float Alpha
		{
			get;
			set;
		}
		
		[Export("visible", ArgumentSemantic.Assign)]
		bool Visible
		{
			get;
			set;
		}
		
		[Export("touchable", ArgumentSemantic.Assign)]
		bool Touchable
		{
			get;
			set;
		}
		
		[Export("name", ArgumentSemantic.Copy)]
		string Name
		{
			get;
			set;
		}
				
		[Export("bounds")]
		SPRectangle Bounds
		{
			get;
		}
		
		[Export("parent")]
		SPDisplayObjectContainer Parent
		{
			get;
		}
		
		[Export("root")]
		SPDisplayObject Root
		{
			get;
		}
		
		[Export("stage")]
		SPStage Stage
		{
			get;
		}
		
		[Export("transformationMatrix")]
		SPMatrix TransformationMatrix
		{
			get;
		}
		
		#endregion
		
		#region Methods
		
		[Export("render:")]
		void Render(SPRenderSupport support);
		
		[Export("removeFromParent")]
		void RemoveFromParent();
		
		[Export("transformationMatrixToSpace:")]
		SPMatrix TransformationMatrixToSpace(SPDisplayObject targetCoordinateSpace);

		[Export("boundsInSpace:")]
		SPRectangle BoundsInSpace(SPDisplayObject targetCoordinateSpace);

		[Export("localToGlobal:")]
		SPPoint LocalToGlobal(SPPoint localPoint);

		[Export("globalToLocal:")]
		SPPoint GlobalToLocal(SPPoint globalPoint);
		
		[Export("hitTestPoint:forTouch:")]
		SPDisplayObject HitTest(SPPoint localPoint, bool isTouch);
		
		[Export("broadcastEvent:")]
		void BroadcastEvent(SPEvent event_);
		
		#endregion
	}
	#endregion
	
	#region SPDisplayObjectContainer (DONE)
	
	public delegate int SPDisplayObjectComparator(SPDisplayObject obj1, SPDisplayObject obj2);
	
	[Abstract]
	[BaseType (typeof(SPDisplayObject))]
	[DisableDefaultCtor]
	public interface SPDisplayObjectContainer
	{
		#region Properties
		
		[Export("numChildren")]
		int Count
		{
			get;
		}
		
		#endregion

		#region Methods
		
		[Export("addChild:")]
		void Add(SPDisplayObject child);
		
		[Internal, Export("addChild:atIndex:")]
		void _AddAtIndex(SPDisplayObject child, int index);
		
		[Export("containsChild:")]
		bool Contains(SPDisplayObject child);
		
		[Internal, Export("childAtIndex:")]
		SPDisplayObject _ChildAtIndex(int index);
		
		[Internal, Export("childByName:")]
		SPDisplayObject _ChildByName(string name);
		
		[Export("childIndex:")]
		int IndexOf(SPDisplayObject child);
		
		[Export("setIndex:ofChild:")]
		void Move(int index, SPDisplayObject child);
		
		[Internal, Export("removeChild:")]
		void _Remove(SPDisplayObject child);
		
		[Export("removeChildAtIndex:")]
		void RemoveAt(int index);
		
		[Export("removeAllChildren")]
		void Clear();
		
		[Export("swapChild:withChild:")]
		void Swap(SPDisplayObject child1, SPDisplayObject child2);
		
		[Export("swapChildAtIndex:withChildAtIndex:")]
		void Swap(int index1, int index2);
		
		[Export("sortChildren:")]
		void Sort(SPDisplayObjectComparator comparator);
		
		#endregion
	}
	#endregion
	
	#region SPQuad (DONE) 
	
	[BaseType(typeof(SPDisplayObject))]
	[DisableDefaultCtor]
	public interface SPQuad
	{
		#region Properties

		[Export("color", ArgumentSemantic.Assign)]
		uint Color
		{
			get;
			set;
		}
		
		#endregion
		
		#region Constructors

		[Export("initWithWidth:height:color:")]
		IntPtr Constructor(float width, float height, uint color);
		
		[Export("initWithWidth:height:")]
		IntPtr Constructor(float width, float height);
		
		#endregion
		
		#region Methods

		[Export("setColor:ofVertex:")]
		void SetColor(uint color, int vertexID);
		
		[Export("colorOfVertex:")]
		uint GetColor(int vertexID);

		#endregion
		
	}
	
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
	
	[BaseType (typeof(SPDisplayObjectContainer))]
	[DisableDefaultCtor]
	public interface SPStage
	{
		#region Static
		
		[Static]
		[Export("mainStage")]
		SPStage MainStage
		{
			get;
		}
		
		[Static]
		[Export("supportHighResolutions")]
		bool SupportHighResolutions
		{
			get;
			set;
		}
	
		// TODO: make internal and add wrapper property in extras
		// to set DoubleResolutionsOnPad using
		// SetSupportHighResolutions(hd, doubleOnPad)
		[Static]
		[Export("doubleResolutionsOnPad")]
		bool DoubleResolutionsOnPad
		{
			get;
		}
		
		[Static]
		[Export("contentScaleFactor")]
		float ContentScaleFactor
		{
			get;
		}
		
		// TODO: internal
		[Static]
		[Export("setSupportHighResolutions")]
		void SetSupportHighResolutions(bool hd, bool doubleOnPad);
		
		#endregion
		
		#region Properties
	
		[Export("frameRate", ArgumentSemantic.Assign)]
		float FrameRate
		{
			get;
			set;
		}
		
		[Export("color", ArgumentSemantic.Assign)]
		uint Color
		{
			get;
			set;
		}
		
		[Export("juggler")]
		SPJuggler Juggler
		{
			get;
		}
		
		[Export("nativeView")]
		SPView NativeView
		{
			get;
		}
		
		#endregion
		
		#region Constructors
		
		[Export("init")]
		IntPtr Constructor();
		
		[Export("initWithWidth:height:")]
		IntPtr Constructor(float width, float height);
		
		#endregion
		
		#region Methods

		[Export("advanceTime:")]
		void AdvanceTime(double seconds);

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
	
	#region SPEvent (DONE*)
	
	/// <summary>
	/// The SPEvent class contains data that describes an event.
 	/// </summary>
 	/// <remarks>
 	/// SPEventDispatcher create instances of this class and send them to registered listeners. An event
	/// contains information that characterizes an event, most importantly the event type and if the event 
	/// bubbles. The target of an event is the object that dispatched it.
 	/// </remarks>
	[BaseType(typeof(NSObject))]
	[DisableDefaultCtor]
	public interface SPEvent
	{
		#region Static (TODO)
		
		/// Factory method.
		//+ (SPEvent*)eventWithType:(NSString*)type bubbles:(BOOL)bubbles;
		
		/// Factory method.
		//+ (SPEvent*)eventWithType:(NSString*)type;

		#endregion
		
		#region Properties
		
		[Export("type")]
		string EventType
		{
			get;
		}
		
		[Export("bubbles")]
		bool Bubbles
		{
			get;
		}
		
		[Export("target")]
		SPEventDispatcher Target
		{
			get;
		}
		
		[Export("currentTarget")]
		SPEventDispatcher CurrentTarget
		{
			get;
		}
				
		#endregion
		
		#region Constructors
		
		[Export("initWithType:bubbles:")]
		IntPtr Constructor(string eventType, bool bubbles);
		
		[Export("initWithType:")]
		IntPtr Constructor(string eventType);
		
		#endregion
		
		#region Methods
		
		[Export("stopImmediatePropagation")]
		void StopImmediatePropagation();
		
		[Export("stopPropagation")]
		void StopPropagation();		
		
		[Internal, Export("stopsImmediatePropagation")]
		bool _StopsImmediatePropagation();
		
		[Internal, Export("stopsPropagation")]
		bool _StopsPropagation();

		#endregion
		
	}
	#endregion
	
	#region SPTouchEvent (TODO) 
	#endregion
	
	#region SPEnterFrameEvent (TODO) 
	#endregion
	
	#region SPJuggler (TODO)
	[BaseType(typeof(NSObject))]
	public interface SPJuggler
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
	
	[BaseType(typeof(NSObject))]
	public interface SPRenderSupport
	{
		
	}
	
	#endregion
	
	#region SPAudioEngine (TODO) 
	#endregion
	
	#region SPSound (TODO) 
	#endregion
	
	#region SPSoundChannel (TODO) 
	#endregion

}

