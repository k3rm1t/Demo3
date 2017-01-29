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
    class Program
    {
        static void Main(string[] args)
        {
            TV tv = new TV();
            tv.Brand = "TeemDeLux";
            tv.Model = "LaHo";
            tv.Power = true;
            tv.Channel = 1;
            tv.PowerOn();
            
            tv.PrintData();
            tv.NextChannel();
            tv.PrintData();
            tv.PrevChannel();
            tv.ShowProgram();
            tv.PrintData();
            tv.SelectChannel();
            tv.PrintData();
            tv.ShowProgram();
        }
    }
}
