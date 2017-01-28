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
            machine.Brand = "TeemuDeLux";
            machine.PrintData();
            machine.PowerOn();
            machine.AskProgram();
            machine.AskTemp();
            machine.AskSpin();
            machine.MachineStart();
            
            machine.PrintData();
        }
    }
}
