using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat[] cats = new Cat[10];

            for (int i = 0; i < cats.Length; i++)
            {
                cats[i] = new Cat("Cat" + Sequence.NextValue(), "purple");
            }

            foreach (var cat in cats)
            {
                cat.SayMiau();
            }
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
