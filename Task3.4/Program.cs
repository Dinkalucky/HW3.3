using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3._4
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            while (true)
            {
                string key;
                Console.WriteLine("Введіть ключ доступу");
                dynamic worker = null;
                key = Console.ReadLine();
                if (key == "exp")
                {
                    worker = new ExpertDocumentWorker();
                }
                else if (key == "pro")
                {
                    worker = new ProDocumentWorker();
                }
                else
                {
                    worker = new DocumentWorker();
                }
                worker.OpenDocument();
                worker.EditDocument();
                worker.SaveDocument();

            }
        }
    }
}
