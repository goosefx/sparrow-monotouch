[Sparrow Framework 1.3 MonoTouch Documentation](../index.md) 
# SPPoolObject

		public class SPPoolObject : NSObject

The SPPoolObject class is an alternative to the base class `NSObject` that manages a pool of objects.
 
Subclasses of SPPoolObject do not deallocate object instances when the retain counter reaches zero. Instead, the objects stay in memory and will be re-used when a new instance of the object is requested. That way, object initialization is accelerated. You can release the memory of all recycled objects anytime by calling the `purgePool` method.
 
Sparrow uses this class for [SPPoint](SPPoint.md), [SPRectangle](SPRectangle.md) and [SPMatrix](SPMatrix.md), as they are created very often as helper objects.
 
To use memory pooling for another class, you just have to inherit from SPPoolObject and copy & paste the following class template:
 
	using System;
	using MonoTouch.Foundation;
	using MonoTouch.ObjCRuntime;

	namespace MyNamespace {
	
		[Register("MyPoolObject")]
		public class MyPoolObject : SPPoolObject {
		
			static IntPtr class_ptr = Class.GetHandle ("MyPoolObject");
	 		static IntPtr selPurgePool = Selector.GetHandle("purgePool");
			static SPPoolInfo poolInfo = null;
	 	
	 		[Export("poolInfo")]
	 		public static SPPoolInfo PoolInfo {
				get {
					if (poolInfo == null) {
						poolInfo = new SPPoolInfo();
					}
					return poolInfo;
				}
			}
		
			public static int PurgePool() {
				return Messaging.int_objc_msgSend(class_ptr, selPurgePool);
			}		
		}
	}

**Note**: This code has not yet been tested!	
	
#SPPoolInfo

	public class SPPoolInfo : NSObject

Internal Helper class for SPPoolObject.

## Constructor

	new SPPoolInfo();
	
Initializes a new SPPoolInfo instance.
		
---

**See Also:**

 - [SPPoint](SPPoint.md)
 - [SPRectangle](SPRectangle.md)
 - [SPMatrix](SPMatrix.md)