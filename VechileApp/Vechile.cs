using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Teemu Joutulainen
// Vechile Application practice
// 29.01.2017
namespace VechileApp
{
    class Vechile
    {
        // field
        // properties
        public string Model { get; set; }
        public string Name { get; set; }
        public int Speed { get; set; }
        public int Tyres { get; set; }
        

        // constructors
        // methods to change properties

        public void Accelerate()
        {
            Speed += 10;
        }
        public void Brake ()
        {
            Speed -= 10;
        }/*
        public Car(string model,string name, int speed, int tyres)
        {
            Model = model;
            Name = name;
            Speed = speed;
            Tyres = tyres;
        }*/
        //methods to show properties
        public void PrintData()
        {
            Console.WriteLine("Data:");
            Console.WriteLine("Car: \t" + Name + "," + Model );
            Console.WriteLine("Tyres:\t" + Tyres + "inc.");
            Console.WriteLine("Speed:\t" + Speed);
        }
    }
}
