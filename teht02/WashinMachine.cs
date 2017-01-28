using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht02 //WashingMachineApplication
{
    class WashinMachine
    {
        //properties
        public bool Power { get; set; }
        public int Temp { get; set; }
        public string Program { get; set; }
        public int Spin { get; set; }
        public string Brand { get; set;}
        public int Delay { get; set; }
        public bool Start { get; set; }
        public bool Lock { get; set; }
    //constructors
    //methods to change something
    //methods to display properties
    public void PrintData()
    {
        Console.WriteLine("This washing machine is made by" + Brand );
            if (Power == true)
            {
                Console.WriteLine("The machine is ON");
            }
            else
            {
                Console.WriteLine("Put the power ON!");
            }
            Console.WriteLine("Program is " + Program);
            Console.WriteLine("Washing temperature is " + Temp + " degrees.");
    }

    }
}
