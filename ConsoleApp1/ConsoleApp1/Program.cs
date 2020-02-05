using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //En lista för de bilar som skapas
            List <Car> bilar = new List<Car>();
            //Inten för bilarna
            int carAmount = Answers();
            //Lägger till bilarna in till listan
            

            // En metod som skulle lägga till bilarna antingen som Contrabandcars eller som Clean cars beroende på vad random generatorn fick för nummer, eftersom att jag inte lyckades få random generatorn att fungera i program lyckades jag inte med metoden.
            //while (carAmount > 0)
            //{
                //int cleanOrContra = generator.Next(1, 2);
                //if (cleanOrContra = 1)
                //{
                    //Car.Add(ContrabandCars);
                //}

                //else
                //{
                    //Car.Add(CleanCars);
                //}

                //carAmount--;
                
            //}

            

            Console.WriteLine("HOW MANY CARS DO YOU WANT TO CREATE?");
            Console.WriteLine("Amount of Cars: " + carAmount);
            Console.ReadLine();

        }

        // En metod som kontrollerar ifall spelaren skriver in en siffra
        // Ifall spelaren inte väljer en siffra eller ett negativt tal kommer spelet be spelaren skriva igen.
        static int Answers()
        {
            int playerchoice = 0;//Det värde som kommer att användas i val av spelare
            string playeranswer = Console.ReadLine();//Spelarens input
            int.TryParse(playeranswer, out playerchoice);//Konverterar spelarens string input till en int
            bool correct = int.TryParse(playeranswer, out playerchoice);//Ser till att konverteringen blev korrekt

            while (correct == false || playerchoice < 1 )
            {
                Console.WriteLine("Please enter a number");

                playerchoice = 0;
                playeranswer = Console.ReadLine();
                correct = int.TryParse(playeranswer, out playerchoice);
            }
            return playerchoice;
        }
    }


}
