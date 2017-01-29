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
            student.StudentId = "h1234";
            student.Address = "Kivakatu 6 Tampere";
            student.Presence = true;
            // student.BigData();
            student.PrintData();
            student[0] = student.Name;
            Console.WriteLine(student[0]);
            
            student.firstname = "Mikko";
            student.lastname = "Kaki";
            student.StudentId = "o6666";
            student.Address = "ikavakatu 66 Vantaa";
            student[1] = student.Name;
            for (int i = 0; i < 2; i++)
            {
                student.Add();
                for (int j= 0; j < 2; j++)
                {
                    student[j++] = student.Name;
                }
            }
            
            
            for ( int i = 0; i < 5; i++) Console.WriteLine("Info\n" + student[i]);
            
        }
    }
}
