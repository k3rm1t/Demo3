using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heaterapplication
{
    class Heater
    {
        // properties
        public bool Power { get; set; }
        public int Temp { get; set; }
        public int Humid { get; set; }
        public int Heating { get; set; }

        // constructors
        // methods to change something
        public Heater()
        {

        }
        public void MoreTemp()
        {
            Temp += 10;
        }
        public void LessHeating()
        {
            Temp -= 10;
        }

        // methods to display properties
        public void PrintData()
        {
            Console.WriteLine("Sauna is " + Power);
            Console.WriteLine("There is " + Temp + " degrees");
            Console.WriteLine("The humidity is " + Humid + " percent.");
            
        }
    }

}
