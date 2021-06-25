using System;
using System.Diagnostics;

namespace ConsoleAppDllImport
{
    class Program
    {
        static void Main(string[] args)
        {
            var result1 = DynamicManagedWrapper1.Wrapper.DoStuff();
            Console.WriteLine($"Library1 returned {result1}");
            if (result1 != 1)
            {
                throw new InvalidOperationException("Library1 returned incorrect value");
            }

            var result2 = DynamicManagedWrapper2.Wrapper.DoStuff();
            Console.WriteLine($"Library2 returned {result2}");
            if (result2 != 2)
            {
                throw new InvalidOperationException("Library2 returned incorrect value");
            }

            Console.WriteLine("Works!");

            if (Debugger.IsAttached)
            {
                Console.WriteLine("Press any key to exit");
                Console.ReadKey();
            }
        }
    }
}
