[Sparrow Framework 1.3 MonoTouch Documentation](index.md) 
# SPEventDispatcher

	abstract class SPEventDispatcher : NSObject

The SPEventDispatcher class is the base for all classes that dispatch events.

The event mechanism is a key feature of Sparrow's architecture. Objects can communicate with each other over events.

An event dispatcher can dispatch events (objects of type [SPEvent](SPEvent.md) or one of its subclasses) to objects that have registered themselves as listeners. A string (the event type) is used to identify different events.

**Here is a sample:**
 
	// dispatching an event
	this.DispatchEvent(new SPEvent("eventType"));
	
	// listening to an event from 'stage'
	stage.AddEventListener("eventType", 
	    delegate(SPEventDispatcher object, SPEventArgs e) {
	        // an event was triggered
	    }
	);
	
As [SPDisplayObject](SPDisplayObject.md), the base object of all rendered objects, inherits from SPEventDispatcher, the event mechanism is tightly bound to the display list. Events that have their `Bubbles` property enabled will rise up the display list until they reach its root (normally the stage). That means that a listener can register for the event type not only on the object that will dispatch it, but on any object that is a direct or indirect parent of the dispatcher. 

### Methods

	public void AddEventListener(string eventType, SPEventHandler eventHandler[, bool retain = false])

Registers an event listener. It is recommended to call this method without `retain`.

	public bool RemoveEventListener(string eventType, SPEventHandler eventHandler)

Removes an event listener.

---	
 
**See Also:**
 
 - [SPEvent](SPEvent.md)
 - [SPDisplayObject](SPDisplayObject.md)
 