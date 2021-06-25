// StaticNativeLibrary1.cpp : Defines the functions for the static library.
//

#include "pch.h"
#include "framework.h"

extern int value;


extern "C" __declspec(dllexport) int DoStuff()
{
	return value;
}
