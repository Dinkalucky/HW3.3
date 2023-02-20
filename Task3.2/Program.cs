using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3._2
{
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
