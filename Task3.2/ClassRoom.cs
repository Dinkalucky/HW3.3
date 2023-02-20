using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3._2
{
    public class ClassRoom
    {
        public ClassRoom(Pupil pupil1, Pupil pupil2, Pupil pupil3, Pupil pupil4)
        {
            Console.WriteLine("Anna:");
            pupil1.Study();
            pupil1.Read();
            pupil1.Write();
            pupil1.Relax();
            Console.WriteLine(new string('*', 10));
            Console.WriteLine("Vlad:");
            pupil2.Study();
            pupil2.Read();
            pupil2.Write();
            pupil2.Relax();
            Console.WriteLine(new string('*', 10));
            Console.WriteLine("Kyrylo:");
            pupil3.Study();
            pupil3.Read();
            pupil3.Write();
            pupil3.Relax();
            Console.WriteLine(new string('*', 10));
            Console.WriteLine("Stefania:");
            pupil4.Study();
            pupil4.Read();
            pupil4.Write();
            pupil4.Relax();
        }
        public ClassRoom(Pupil pupil1, Pupil pupil2, Pupil pupil3)
        {
            Console.WriteLine("Illa:");
            pupil1.Study();
            pupil1.Read();
            pupil1.Write();
            pupil1.Relax();
            Console.WriteLine(new string('*', 10));
            Console.WriteLine("Svitlana:");
            pupil2.Study();
            pupil2.Read();
            pupil2.Write();
            pupil2.Relax();
            Console.WriteLine(new string('*', 10));
            Console.WriteLine("Nadia:");
            pupil3.Study();
            pupil3.Read();
            pupil3.Write();
            pupil3.Relax();
        }
        public ClassRoom(Pupil pupil1, Pupil pupil2)
        {
            Console.WriteLine("Oleksandr:");
            pupil1.Study();
            pupil1.Read();
            pupil1.Write();
            pupil1.Relax();
            Console.WriteLine(new string('*', 10));
            Console.WriteLine("Ira:");
            pupil2.Study();
            pupil2.Read();
            pupil2.Write();
            pupil2.Relax();
        }
    }
}
