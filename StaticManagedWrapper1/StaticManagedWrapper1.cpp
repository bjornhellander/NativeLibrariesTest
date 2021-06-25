#include "pch.h"

#include "StaticManagedWrapper1.h"

extern "C" int DoStuff();

namespace StaticManagedWrapper1
{
	int Wrapper::DoStuff()
	{
		return ::DoStuff();
	}
}
