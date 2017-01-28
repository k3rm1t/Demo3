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
        public string Spin { get; set; }
        public string Brand { get; set;}
        public int Delay { get; set; }
        public bool Start { get; set; }
        public bool Lock { get; set; }
        
        //constructors
        //methods to change properties
        public void PowerOn()
        {
            Console.WriteLine("Turn washing machine\n1 -> \t\tON\n2 ->\t\tOFF ");
            int i = int.Parse(Console.ReadLine());
            switch (i)
            {
                case 1: Console.WriteLine("Machine is ON.");
                    Power = true;
                    break;
                case 2: Console.WriteLine("Machine is OFF.");
                    Power = false;
                    break;
                default:Console.WriteLine("Not an option.");
                    break;                        
            }            
        }
        public void AskProgram()
        {
            if (Power == true) { 
            Console.WriteLine("Select washing program ->");
            Console.WriteLine("1.\tSilk\n2.\tRegular\n3.\tLingerie");
            int j = int.Parse(Console.ReadLine());
            if (j == 1)
            {
                Program = "Silk";
            }
            else if (j == 2)
            {
                Program = "Regular";
            }
            else Program = "Lingerie";
            Console.WriteLine("Your program is " + Program);
        }
        }
        public void AskTemp()
        {
            if (Power == true) { 
            Console.WriteLine("Select washing temperature ->");
            int i = int.Parse(Console.ReadLine());
            if (i < 30 || i > 90)
            {
                Console.WriteLine("Select your temperature wisely.");
            }
            Temp = i;
            Console.WriteLine("Termperature is " + Temp);
        }
        }

        public void AskSpin()
        {
            if (Power == true) { 
            Console.WriteLine("Select Spin speed ->");
            Console.WriteLine("1.\t700 rpm\n2.\t1400 rpm");
            int i = int.Parse(Console.ReadLine());
            if (i == 1)
            {
                Spin = "700 rpm";
            }
            else Spin = "1400 rpm";
            Console.WriteLine("Spinning speed is " + Spin);
        }
        }
        public void MachineStart()
        {
            if (Power == true)
            {
                Start = true;
                Console.WriteLine("Machine is washing.");
            }
            else Console.WriteLine("Go home Charlie...");
        }
        
        /*
    public void MoreTemp()
        {
            Temp += 10;
        }
    public void LessTemp()
        {
            Temp -= 10;
        }
    public void NewProgram()
        {

        }
        public void DoorLock()
        {
            if (Power == true && Start == true)
            {
                //Lock = true;
                Console.WriteLine("Door is locked.");
            }
            else if (Power == true && Lock == false)
            {
                Console.WriteLine("Close the door and press start.");
            }
        }
        public void StartProgram()
        {
            if (Power == true && Lock == true)
            {
                Console.WriteLine("Program " + Program + " Started.");
            }
            else if (Power == true && Lock == false) {
                Console.WriteLine("Close the door and start again.");
                    }
        }
   
                    
                   
                
        */
    //methods to display properties
    public void PrintData()
    {
        Console.WriteLine("This washing machine is made by " + Brand );
           /* if (Power == true)
            {
                Console.WriteLine("The machine is ON");
                Console.WriteLine("Program is " + Program);
                Console.WriteLine("Washing temperature is " + Temp + " degrees.");
                Console.WriteLine("Spinning is " + Spin + " rpm/min.");
                Console.WriteLine("Machine is washing");
            }

            else
            {
                Console.WriteLine("Machine is OFF.\nPut the power ON!");
                
            }
            */
    }

    }
}
