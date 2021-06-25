#include "pch.h"

#include "DynamicManagedWrapper2.h"

extern "C" int DoStuff();

namespace DynamicManagedWrapper2
{
	int Wrapper::DoStuff()
	{
		return ::DoStuff();
	}
}
