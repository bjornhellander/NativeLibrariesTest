#include "pch.h"


extern int value;


extern "C" __declspec(dllexport) int DoStuff()
{
	return value;
}
