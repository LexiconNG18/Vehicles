using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car("ABC123", "Volvo", "beige", 100);
            car.Drive(-50);
            car.Color = "infrared";
           
            Console.WriteLine("mileage: " + car.Mileage);

            Car other = new Car("BCD234", "SAAB", "fuchsia")
            {
                Owner = "Nicke",
            };
        }
























        private static void FirstTest()
        {
            //Car car1 = new Car();
            //Car car2 = new Car();
            //Car car3 = car1;

            //car1.RegNo = "ABC123";
            //car2.RegNo = "BCD234";

            ////Console.WriteLine("car 1: " + car1.RegNo);
            ////Console.WriteLine("car 2: " + car2.RegNo);
            ////Console.WriteLine("car 3: " + car3.RegNo);

            //car1.SetColor("black");
            ////Console.WriteLine("color: " + car1.GetColor());
            //car1.SetColor(null);
            ////Console.WriteLine("color: " + car1.GetColor());

            //car2.SetColor("blue");

            //string color = car2.GetColor();
            //color = "light" + color;
            //car2.SetColor(color);
            //Console.WriteLine("color: " + car2.GetColor());

            //car3.SetColor("red");

            //car3.SetColor("light" + car3.GetColor());
            //car3.Color = "light" + car3.Color;
            //Console.WriteLine("color: " + car3.GetColor());
        }
    }
}
