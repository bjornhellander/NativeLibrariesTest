This solution builds two native C++ libraries, in both static (.lib) and dynamic (.dll) versions.
Each library exports a function with the same name in both libraries.
Each library's function returns a separate value, to be able to know that the correct library has actually been used.
Each library consists of two source files, to see that "internal" symbols inside each library are referenced correctly.

It also builds three different C# applications which calls both functions:
1) One using the .NET DllImport mechanism, which seems to load the libraries dynamically using LoadLibrary and GetProcAddress.
https://stackoverflow.com/questions/14471571/how-does-dllimport-really-work
https://docs.microsoft.com/en-us/dotnet/framework/interop/consuming-unmanaged-dll-functions
2) One using Managed C++ libraries which links the native libraries dynamically.
3) One using Managed C++ libraries which links the native libraries statically.
   This last mechanism embeds the static native library inside a managed DLL, isolating it completely from the outside as fas as linking is concerned.

All three applications work, showing different ways to use more than one library with conflicting exported symbols inside the same .NET process.
