using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Greetings user! Meet your virtual pet Terry the Squirrel!");
            Console.WriteLine();

            Squirrel terry = new Squirrel(10, 10, 10);

            //This is where the program will re-start after the loop has ran
            start:

            //The program will write out Terry's hunger, thirst, and bathroom levels
            terry.PrintPetInfo();
            Console.WriteLine();

            //The program will write out the different options to interact with Terry
            terry.PrintPetOptions();
            Console.WriteLine();
            int userInput = int.Parse(Console.ReadLine());

            
            while(userInput == userInput)
            {
                if (userInput == 1)
                {
                    terry.FeedTerry();
                    Console.WriteLine();
                    goto start;
                }

                else if (userInput == 2)
                {
                    terry.WaterTerry();
                    Console.WriteLine();
                    goto start;
                }

                else if (userInput == 3)
                {
                    terry.TakeTerryPotty();
                    Console.WriteLine();
                    goto start;
                }

                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Please enter a number 1-3");
                    Console.WriteLine();
                    goto start;
                }
            }


        }
    }
}
