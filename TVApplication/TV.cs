using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Teemu Joutulainen
// TV Application practice
// 28.01.2017
namespace TVApplication
{
    class TV
    {
        //field
        // Properties
        public string Brand { get; set; }
        public string Model { get; set; }
        public bool Power { get; set; }
        public int Volume { get; set; }
        public int Channel { get; set; }
        public string ChName { get; set; }
        public string Program { get; set; }
        public string Network { get; set; }
        public int Brightness { get; set; }
        // Constructors
        // Methods to change properties
        public void PowerOn()
        {
            if (Power == true)
            {
                Console.WriteLine(Brand + " TV is on.\nModel is " + Model);
            }
            else Console.WriteLine("");
        }
        public void NextChannel()
           
        {
            if (Power == true)
            {
                Channel += 1;
            }
            else Console.WriteLine("");
        }
        public void PrevChannel()
        {
            if (Power == true) { 
                Channel -= 1;
        }
        }
        public void SelectChannel()
        {
            if (Power == true)
            {
                Console.WriteLine("Select channel you want to watch.");
                Console.WriteLine("ÜLE 1\t\t1\nÜle 2\t\t2\nMainio TV\t3");
                int i = int.Parse(Console.ReadLine());
                Channel = i;
            }
            
        }
        public void ShowProgram()
        {

            if (Power == true && Channel == 3 || Channel == 2 || Channel == 1)
            { 
                        switch (Channel)
                    {
                        case 1: Program = "Ütiset";
                            break;
                        case 2: Program = "Die Kühe(Ratkaisijat)";
                            break;
                        case 3: Program = "Mainio tv";
                            break;
                        default: Console.WriteLine("No such channel");
                            break;
                    }
                    if (Power == true)
                    {
                        Console.WriteLine("Program you are watching is " + Program + " on channel " + Channel + " " + ChName);
                    }
             }
        }

        public void ChangeBrightness()
        {
            if (Power == true)
            {
                Console.WriteLine("Brightness is currently " + Brightness);
                Console.WriteLine("To change brightness. Press +(plus sign) to add - (minus sign) to decrease.");
                string n = Console.ReadLine();
                switch (n)
                {
                    case "+": Brightness += 10;
                        break;
                    case "-": Brightness -= 10;
                        break;
                    default: Console.WriteLine("Not an option.");
                        break;
                }
            }
            Console.WriteLine("New brigthness is " + Brightness);
        }
        // Methods to display properties
        public void PrintData()
        {
            if (Power == true && Channel == 3 ||Channel == 2 || Channel == 1) { 
            switch (Channel) {
                case 1: ChName = "ÜLE 1";
                    break;
                case 2: ChName = "ÜLE 2";
                    break;
                case 3: ChName= "Mainostus TeeVee 3";
                    break;
                default:Console.WriteLine("Chinese rise war");
                    break;
            }
                if (Power == true)
                { 
                    Console.WriteLine("");
                    Console.WriteLine("Channel is now " + Channel);
                }
            }
        }
        // Destructor
        ~TV()
        {
            Console.WriteLine("TV object destroyed.");
        }
    }
}
