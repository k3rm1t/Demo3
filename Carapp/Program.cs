using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carapp
{
    class Program
    {
        static void Main(string[] args)
        {
            // create one instance of car class
            Car car = new Car();
            car.PrintData();
            car.Model = "Datasun 100A";
            car.Color = "Grey";
            car.Engine = 1.2;
            car.Speed = 10;
            car.FuzzyDices = true;
            car.DoorCount = 2;
            Car.SomeProperty = 100; //static property
            car.PrintData();
            car.Accelerate();
            Console.WriteLine("Speed = " + car.Speed);
            car.Brake(2);
            Console.WriteLine("Speed = " + car.Speed);

            //create a new instace from Car class
            Car nascar = new Car("Speedstrep");
            nascar.PrintData();
            nascar.Color = "Black";
            nascar.Engine = 6;
            nascar.FuzzyDices = true;
            nascar.PrintData();

        }
    }
}
