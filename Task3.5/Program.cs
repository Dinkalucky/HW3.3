using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            while (true)
            {
                string value;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Введіть аргумент");
                value = Console.ReadLine();

                Printer printer = new Printer();
                printer.Print(value);

                RedPrinter redPrinter = new RedPrinter();
                redPrinter.Print(value);

                GreenPrinter greenPrinter = new GreenPrinter();
                greenPrinter.Print(value);

                YellowPrinter yellowPrinter = new YellowPrinter();
                yellowPrinter.Print(value);
            }
        }
    }
}
