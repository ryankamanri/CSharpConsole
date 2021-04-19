using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpConsole
{
    static class ConsoleIO
    {
        public static string Scan ()
        {
            return Console.ReadLine();
        }
        public static void Print(object obj)
        {
            Console.WriteLine(obj);
        }
    }
}
