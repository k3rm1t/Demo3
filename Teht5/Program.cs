using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Teemu Joutulainen
// Student Application practice
// 29.01.2017
namespace Teht5
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.firstname = "Seppo";
            student.lastname = "Maki";
            student.PrintData();
        }
    }
}
