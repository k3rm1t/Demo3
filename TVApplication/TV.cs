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
        // Properties
        public bool Power { get; set; }
        public int Volume { get; set; }
        public int Channel { get; set; }
        public string ChName { get; set; }
        public string Program { get; set; }
        public string Network { get; set; }
        public int brightness { get; set; }
        // Constructors
        // Methods to change properties
        public void PowerOn()
        {
            if (Power == true)
            {
                Console.WriteLine("TV is on.");
            }
        }
        public void NextChannel()
           
        {
            if (Power == true)
            {
                Channel += 1;
        } }
        public void PrevChannel()
        {
            if (Power == true) { 
                Channel -= 1;
        }
        }
        public void SelectChannel()
        {
            Console.WriteLine("Select channel you want to watch.");
            Console.WriteLine("ÜLE 1\t1\nÜle 2\t2\nMainio TV\t3");
            int i = int.Parse(Console.ReadLine());
            Channel = i;
        }
        public void ShowProgram()
        {
            if (Channel == 1)
            {
                Program = "Üutiset";
            }
            else if (Channel == 2)
            {
                Program = "Die Kühe(Ratkaisijat)";
            }
            else Program = "Ostas TEEVee";
            Console.WriteLine("Program you are watching is " + Program + " on channel " + Channel +" "+ ChName);
        }
        // Methods to display properties
        public void PrintData()
        {
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
            Console.WriteLine("Channel is " + Channel);
        }
        // Destructors
    }
}
