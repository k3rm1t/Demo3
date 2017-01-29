using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            TV tv = new TV();
            tv.Power = true;
            tv.PowerOn();
            tv.PrintData();
            tv.Channel = 1;
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
