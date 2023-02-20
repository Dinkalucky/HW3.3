using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3._3
{
    public class Ship : Vehicle
    {
        public int port;
        public int numberOfPassagiers;

        public Ship(int port, int numberOfPassagiers)
        {
            this.port = port;
            this.numberOfPassagiers = numberOfPassagiers;
            coordinateX = 234;
            coordinateY = 761;
            price = 393753;
            speed = 5000;
            year = 2022;
        }
    }
}
