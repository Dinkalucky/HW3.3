using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3._2
{
    public class BadPupil : Pupil
    {
        public void Study()
        {
            Console.WriteLine("Study - 2");
        }
        public void Read()
        {
            Console.WriteLine("Read - 2");
        }
        public void Write()
        {
            Console.WriteLine("Write - 2");
        }
        public void Relax()
        {
            Console.WriteLine("Relax - 5");
        }
    }
}
