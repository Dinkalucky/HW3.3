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

    public class Pupil
    {
        public void Study()
        {
            Console.WriteLine("Study - 3");
        }
        public void Read()
        {
            Console.WriteLine("Read - 3");
        }
        public void Write()
        {
            Console.WriteLine("Write - 3");
        }
        public void Relax()
        {
            Console.WriteLine("Relax - 3");
        }

    }

    public class ExcelentPupil : Pupil
    {
        public void Study()
        {
            Console.WriteLine("Study - 5");
        }
        public void Read()
        {
            Console.WriteLine("Read - 5");
        }
        public void Write()
        {
            Console.WriteLine("Write - 5");
        }
        public void Relax()
        {
            Console.WriteLine("Relax - 2");
        }
    }

    public class GoodPupil : Pupil
    {
        public void Study()
        {
            Console.WriteLine("Study - 4");
        }
        public void Read()
        {
            Console.WriteLine("Read - 4");
        }
        public void Write()
        {
            Console.WriteLine("Write - 4");
        }
        public void Relax()
        {
            Console.WriteLine("Relax - 4");
        }
    }

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
    internal class Program
    {
        static void Main(string[] args)
        {
            ExcelentPupil excelentPupil = new ExcelentPupil();
            GoodPupil goodPupil = new GoodPupil();
            Pupil pupil = new Pupil();
            BadPupil badPupil = new BadPupil();
            Console.WriteLine("Class A");
            ClassRoom classRoomA = new ClassRoom(excelentPupil,goodPupil,pupil,badPupil);
            Console.WriteLine(new string('-', 10));
            Console.WriteLine("Class B");
            ClassRoom classRoomB = new ClassRoom(excelentPupil, goodPupil, pupil);
            Console.WriteLine(new string('-', 10));
            Console.WriteLine("Class C");
            ClassRoom classRoomC = new ClassRoom(excelentPupil, badPupil);

            Console.Read();
        }
    }
}
