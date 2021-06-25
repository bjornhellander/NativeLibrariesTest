#include "pch.h"

#include "DynamicManagedWrapper1.h"

extern "C" int DoStuff();

namespace DynamicManagedWrapper1
{
	int Wrapper::DoStuff()
	{
		return ::DoStuff();
	}
}
