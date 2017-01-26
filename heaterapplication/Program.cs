using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heaterapplication
{
    class Program
    {
        static void Main(string[] args)
        {
            // create one instance of Heater class
            Heater heater = new Heater();
            heater.PrintData();
            heater.Power = true;
            heater.Humid = 80;
            heater.Temp = 90;
            
            heater.PrintData();
            heater.MoreTemp();
            heater.PrintData();
            heater.LessHeating();
            heater.LessHeating();
            heater.PrintData();

        }
    }
}
