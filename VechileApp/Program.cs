using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Teemu Joutulainen
// Vechile Application practice
// 29.01.2017
namespace VechileApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Vechile vechile = new Vechile();
            vechile.Name = "Audi";
            vechile.Model = "A4";
            vechile.Speed = 120;
            vechile.Tyres = 20;
            vechile.PrintData();
        }
    }
}
