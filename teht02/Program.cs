using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht02 //wahsing machine application
{
    class Program
    {
        static void Main(string[] args)
        {
            //create one instance of WashincMachine class
            WashinMachine machine = new WashinMachine();
            machine.Brand = "ElectroLux";
            machine.Power = true;
            machine.Program = "Silk";
            machine.Temp = 30;
            machine.PrintData();
        }
    }
}
