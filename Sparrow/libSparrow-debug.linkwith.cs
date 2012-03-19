#if DEBUG

using System;
using MonoTouch.ObjCRuntime;

[assembly: LinkWith ("libSparrow-debug.a", LinkTarget.ArmV6 | LinkTarget.ArmV7 | LinkTarget.Simulator, Frameworks = "Foundation CoreGraphics QuartzCore OpenGLES UIKit OpenAL AudioToolbox AVFoundation", ForceLoad = true)]

#endif