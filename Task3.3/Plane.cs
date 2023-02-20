using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3._3
{
    public class Plane : Vehicle
    {
        public int height;
        public int numberOfPassagiers;

        public Plane(int height, int numberOfPassagiers)
        {
            this.height = height;
            this.numberOfPassagiers = numberOfPassagiers;
            coordinateX = 435;
            coordinateY = 102;
            price = 12345965;
            speed = 3004;
            year = 2006;
        }
    }
}
