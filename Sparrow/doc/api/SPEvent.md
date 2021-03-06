[Sparrow Framework 1.3 MonoTouch Documentation](../index.md) 
# SPEvent

	public class SPEvent : NSObject, SPEventArgs
	
The SPEvent class contains data that describes an event. 

[SPEventDispatcher](SPEventDispatcher.md) create instances of this class and send them to registered listeners. An event contains information that characterizes an event, most importantly the event type and if the event bubbles. The target of an event is the object that dispatched it.

For some event types, this information is sufficient; other events may need additional information to be carried to the listener. 

In that case, you can subclass SPEvent and add properties with all the information you require. The [SPEnterFrameEvent](SPEnterFrameEvent.md) is an example for this practice; it adds a property about the time that has passed since the last frame.
 
Furthermore, the event class contains methods that can stop the event from being processed by other listeners - either completely or at the next bubble stage.

**The following event types are predefined:**

 - `added` --> use const `SPEventType.Added`
 - `addedToStage` --> use const `SPEventType.AddedToStage`
 - `removed` --> use const `SPEventType.Removed`
 - `removedFromStage` --> use const `SPEventType.RemovedFromStage`

These events will need additional information:

 - `touch` --> use const `SPEventType.Touch` (see also: [SPTouchEvent](SPTouchEvent.md))
 - `enterFrame` --> use const `SPEventType.EnterFrame` (see also: [SPEnterFrameEvent](SPEnterFrameEvent.md))

## Properties

 - `EventType` : A string that identifies the event. *(readonly)*
 - `Bubbles` : Indicates if event will bubble. *(readonly)*
 - `Target` : The [object](SPEventDispatcher.md) that dispatched the event. *(readonly)*
 - `CurrentTarget` : The [object](SPEventDispatcher.md) the event is currently bubbling at. *(readonly)*

## Constructors

	new SPEvent(string eventType[, bool bubbles = false])

## Methods

	void StopImmediatePropagation()
	
Prevents any other listeners from receiving the event. Normally you would use the `Cancel` property of SPEventArgs instead (see below).

	void StopPropagation();
	
Prevents listeners at the next bubble stage from receiving the event. As an event listener you can set the `Bubbles` property of SPEventArgs to `false` (see below).

# SPEventArgs

	public interface SPEventArgs

Thus, native events integrate better into `.NET`, we have used a little trick. SPEventArgs mimics the functionality of `System.ComponentModel.CancelEventArgs`. Setting the `Cancel` property to `true` will immediatly stop the event propagation. Also we have declared all common native events as `.NET` events.

**Here is a sample:**

	child.Added += delegate(SPEventDispatcher source, SPEventArgs e) {
		// do something 
	};

## Properties

 - `EventType` : A string that identifies the event. *(readonly)*
 - `Bubbles` : Prevents listeners at the next bubble stage from receiving the event. **Note** that you can never force a non-bubbling event to bubble (this will trigger an exception).
 - `Cancel` : Prevents any other listeners from receiving the event. **Note** that you can never resurrect a canceled event (this will trigger an exception).
 - `Origin` : The [object](SPEventDispatcher.md) that original dispatched the event. *(readonly)*


# SPEventHandler

	public delegate void SPEventHandler(SPEventDispatcher source, SPEventArgs e);
	
Represents the method that will handle an SPEvent.

---	

**See Also:**
 
 - [SPTouchEvent](SPTouchEvent.md)
 - [SPEnterFrameEvent](SPEnterFrameEvent.md)
 - [SPEventDispatcher](SPEventDispatcher.md)