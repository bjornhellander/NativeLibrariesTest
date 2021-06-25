#include "pch.h"

#include "StaticManagedWrapper2.h"

extern "C" int DoStuff();

namespace StaticManagedWrapper2
{
	int Wrapper::DoStuff()
	{
		return ::DoStuff();
	}
}
