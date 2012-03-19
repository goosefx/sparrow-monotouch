# MonoTouch Bindings for Sparrow 1.3

 - MonoTouch: http://xamarin.com/monotouch
 - Sparrow Framework: https://github.com/PrimaryFeather/Sparrow-Framework

*Further Information:*

 - Binding Obj-C Types: http://docs.xamarin.com/ios/advanced_topics/binding_objective-c_types
 - Outdated Binding Approach: https://github.com/trustme/Sparrow

## Status Quo

Currently only a few classes are bound to MonoTouch. So far the bindings seems to work with one exception: **YOU CAN'T DERRIVE FROM A SPARROW CLASS !!!**

**UPDATE**

I now have found the reason for this: the `/e` argument of `btouch` (see bug [#3234](https://bugzilla.xamarin.com/show_bug.cgi?id=3234)). That's why `mtouch` does not generate subclassable types. To bad that `MonoDevelop` does not allow me to change this default behavior (for Binding Projects). As a workaround you have to run `btouch` again but without `/e`:

	/Developer/MonoTouch/usr/bin/btouch /d:DEBUG ApiDefinition.cs /s:StructsAndEnums.cs /tmpdir:obj/Debug/ios/ /sourceonly:obj/Debug/ios/sources.list	
And of cause every following build step :( 
	
	/Developer/MonoTouch/usr/bin/smcs /noconfig /debug:full /debug+ /optimize- /out:obj/Debug/Sparrow.dll …
	cp '/Users/marcus/Projects/iOS/sparrow-monotouch/Sparrow/obj/Debug/Sparrow.dll.mdb' '/Users/marcus/Projects/iOS/sparrow-monotouch/Sparrow/bin/Debug/Sparrow.dll.mdb'
	cp '/Users/marcus/Projects/iOS/sparrow-monotouch/Sparrow/obj/Debug/Sparrow.dll' '/Users/marcus/Projects/iOS/sparrow-monotouch/Sparrow/bin/Debug/Sparrow.dll'
  

## How to create universial static library libSparrow.a

	$ git clone https://github.com/PrimaryFeather/Sparrow-Framework.git

Compile Sparrow with `Xcode` for device and simulator

Navigate to `Sparrow/Products` inside the Project navigator

Right click on `libSparrow.a` and then choose `Show in Finder`

Navigate two directories up
 
Open `Terminal` and drag the path from the Finder into it:
 
 	$ cd ~/Library/Developer/Xcode/DerivedData/Sparrow.../Build/Products

Now use `lipo` to create a fat universial library:

	$ lipo -output 'libSparrow-debug.a' -create 'Debug-iphoneos/libSparrow.a' -arch i386 'Debug-iphonesimulator/libSparrow.a'

Change the build configuration to release and build again (twice)

	$ lipo -output 'libSparrow-release.a' -create 'Release-iphoneos/libSparrow.a' -arch i386 'Release-iphonesimulator/libSparrow.a'

Now you have two universial static libraries, one for debug and one for release.

