using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07
{
    class CatAndSequenceCaller
    {

        static void Main(string[] args)
        {
            Cat someCat = new Cat("John", "red");
            someCat.SayMiau();
            Console.WriteLine("The color of cat {0} is {1}.", someCat.Name, someCat.Color);
        }
    }



    class Cat
    {
        private string name;
        private string color;

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }

        public string Color
        {
            get
            {
                return this.color;
            }
            set
            {
                this.color = value;
            }
        }

        public Cat()
        {
            this.name = "Unnamed";
            this.color = "gray";
        }

        public Cat(string name, string color)
        {
            this.name = name;
            this.color = color;
        }

        public void SayMiau()
        {
            Console.WriteLine("Cat {0} said: Miauuuuuu!", name);
        }
    }
    class Sequence
    {
        private static int currentValue = 0;

        private Sequence()
        {

        }

        public static int NextValue()
        {
            currentValue++;
            return currentValue;
        }
    }

}
