using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class CleanCars : Car
    {
        public CleanCars()
        {
            passangers = generator.Next(1, 4);
            contrabandAmount = 0;
            Print();
        }
    }
}
