using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace ConsoleAppDllImport
{
    static class Library1NativeMethods
    {
        [DllImport("DynamicNativeLibrary1.dll")]
        public static extern int DoStuff(); // Note: Same name in both libraries
    }

    static class Library2NativeMethods
    {
        [DllImport("DynamicNativeLibrary2.dll")]
        public static extern int DoStuff(); // Note: Same name in both libraries
    }

    class Program
    {
        static void Main(string[] args)
        {
            var result1 = Library1NativeMethods.DoStuff();
            Console.WriteLine($"Library1 returned {result1}");
            if (result1 != 1)
            {
                throw new InvalidOperationException("Library1 returned incorrect value");
            }

            var result2 = Library2NativeMethods.DoStuff();
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
