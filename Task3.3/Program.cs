using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Info about Plane:");
            Plane plane = new Plane(24, 500);
            Console.WriteLine($"CoordinateX: {plane.coordinateX}\n"+
                              $"CoordinateY: {plane.coordinateY}\n"+
                              $"Price: {plane.price}\n" +
                              $"Speed: {plane.speed}\n" +
                              $"Year: {plane.year}\n" +
                              $"Height: {plane.height}\n" +
                              $"NumberOfPassagiers: {plane.numberOfPassagiers}\n");
            Console.WriteLine(new string('*', 10));
            Console.WriteLine("Info about Car:");
            Car car = new Car();
            Console.WriteLine($"CoordinateX: {car.coordinateX}\n" +
                              $"CoordinateY: {car.coordinateY}\n" +
                              $"Price: {car.price}\n" +
                              $"Speed: {car.speed}\n" +
                              $"Year: {car.year}\n");
            Console.WriteLine(new string('*', 10));
            Console.WriteLine("Info about Ship:");
            Ship ship = new Ship(23, 1542);
            Console.WriteLine($"CoordinateX: {ship.coordinateX}\n" +
                              $"CoordinateY: {ship.coordinateY}\n" +
                              $"Price: {ship.price}\n" +
                              $"Speed: {ship.speed}\n" +
                              $"Year: {ship.year}\n" +
                              $"Height: {ship.port}\n" +
                              $"NumberOfPassagiers: {ship.numberOfPassagiers}\n");
            Console.ReadLine();
        }
    }
}
