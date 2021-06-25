This solution builds two native DLLs. Each one exports a function with the same name in both DLLs.

It also builds a C# console application loads and calls both functions using the .NET DllImport mechanism, which seems to use
LoadLibrary and GetProcAddress under the hood.
https://stackoverflow.com/questions/14471571/how-does-dllimport-really-work
https://docs.microsoft.com/en-us/dotnet/framework/interop/consuming-unmanaged-dll-functions
