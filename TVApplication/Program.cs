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
            tv.NextChannel();
            tv.PrintData();
        }
    }
}
