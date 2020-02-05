using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Car
    {
        public int passangers;
        public int contrabandAmount;
        public bool alreadyChecked;
        public Random generator = new Random();

        

        public bool Examine()
        {
            return alreadyChecked;
        }

        public void Print()
        {
            Console.WriteLine("Passangers: " + passangers );
            Console.WriteLine("Contraband: " + contrabandAmount);
        }



    }
}
