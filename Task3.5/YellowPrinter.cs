using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3._5
{
    internal class YellowPrinter : Printer
    {
        public void Print(string value)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Your argument: {value}");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
