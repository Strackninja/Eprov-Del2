using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class ContrabandCars: Car
    {
        public ContrabandCars()
        {
            passangers = generator.Next(1, 5);
            contrabandAmount = generator.Next(1, 5);
            Print();
        }
    }
}
