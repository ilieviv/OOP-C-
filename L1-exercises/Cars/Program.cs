using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
    class Program
    {
        static void Main(string[] args)
        {
            Car bmw = new Car("bmw", "325", 280, 100000);
            Car audi = new Car("audi", "s8", 360, 50000);
            Car mercedes = new Car("mercedes", "s-classe", 400, 980000);

            //List<Car> cars = new List<Car>()
            //{ bmw, audi, mercedes };

            //foreach (var car in cars)
            //{
            //    car.Info();
            //}
                
            var carsArray = new Car[] { bmw, audi, mercedes };
            for (int i = 0; i < carsArray.Length; i++)
            {
                Console.WriteLine(carsArray[i].DisplayInfo);
            }


        }
    }

    class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Speed { get; set; }
        public decimal Price { get; set; }

        public Car(string brand, string model, int speed, decimal price)
        {
            this.Brand = brand;
            this.Model = model;
            this.Speed = speed;
            this.Price = price;
        }
        public string DisplayInfo
        {
            get
            {
                return $"{this.Brand} {this.Model} - {this.Speed} at price {this.Price}";
            }
        }

        public void Info()
        {
            Console.WriteLine($"{this.Brand} {this.Model} - {this.Speed} at price {this.Price}");
        }
    }
}
