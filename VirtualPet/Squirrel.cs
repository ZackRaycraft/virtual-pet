using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet
{
    class Squirrel
    {
        private int hunger;
        private int thirst;
        private int waste;

        public int Hunger
        {
            get { return this.hunger; }
            set { this.hunger = value; }
        }

        public int Thirst
        {
            get { return this.thirst; }
            set { this.thirst = value; }
        }

        public int Waste
        {
            get { return this.waste; }
            set { this.waste = value; }
        }

        public Squirrel(int hunger, int thirst, int waste)
        {
            this.hunger = hunger;
            this.thirst = thirst;
            this.waste = waste;
        }

        public void PrintPetInfo()
        {
            Console.WriteLine("Terry the Squirrel");
            Console.WriteLine("Hunger: " + hunger);
            Console.WriteLine("Thirst: " + thirst);
            Console.WriteLine("Waste: " + waste);
        }

        public void PrintPetOptions()
        {
            Console.WriteLine("What do you wish to do? Please select a number 1-3!");
            Console.WriteLine("1. Feed Terry");
            Console.WriteLine("2. Give Terry waster");
            Console.WriteLine("3. Take Terry outside to go potty");
        }

        public int FeedTerry()
        {
            hunger--;
            thirst++;
            return hunger;
        }

        public int WaterTerry()
        {
            thirst--;
            waste++;
            return thirst;
        }

        public int TakeTerryPotty()
        {
            waste--;
            return waste;
        }
    }

   
}
