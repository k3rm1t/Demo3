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
            while (Power == true)
            {
                Channel += 1;
        } }
        public void PrevChannel()
        {
            while (Power == true) { 
                Channel -= 1;
        }
        }
        public void SelectChannel()
        {
            Console.WriteLine("Select channel you want to watch.");
            int i = int.Parse(Console.ReadLine());
            Channel = i;
        }
        // Methods to display properties
        public void PrintData()
        {
            Console.WriteLine("Channel is " + Channel);
        }
        // Destructors
    }
}
