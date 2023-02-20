using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3._4
{
    public class ExpertDocumentWorker : ProDocumentWorker
    {
        public void SaveDocument()
        {
            Console.WriteLine("Документ збережений у новому форматі");
        }
    }
}
