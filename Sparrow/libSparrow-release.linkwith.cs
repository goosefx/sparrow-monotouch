using System;
using MonoTouch.ObjCRuntime;

[assembly: LinkWith ("libSparrow-release.a", LinkTarget.Simulator, ForceLoad = true)]
