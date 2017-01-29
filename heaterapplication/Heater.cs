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
        public string Brand { get; set; }
        // constructors
        // methods to change something
        public Heater()
        {

        }
        public void MoreTemp()
        {
            Temp += 10;
        }
        public void LessTemp()
        {
            Temp -= 10;
        }
        public void MoreHumid()
        {
            Humid += 10;
        }
        public void LessHumid()
        {
            Humid -= 30;
        }
        // methods to display properties
        public void PrintData()
        {
            Console.WriteLine("This sauna stove is made by " + Brand);
            Console.WriteLine("Sauna is " + Power);
            Console.WriteLine("There is " + Temp + " degrees");
            Console.WriteLine("The humidity is " + Humid + " percent.");
            
        }
    }

}
