using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3._4
{
    public class ProDocumentWorker : DocumentWorker
    {
        public void EditDocument()
        {
            Console.WriteLine("Документ відредаговано");
        }
        public void SaveDocument()
        {
            Console.WriteLine("Документ збережено у старому форматі, збереження в інших форматах є у версії Експерт");
        }
    }
}
