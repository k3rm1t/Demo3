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
    class Student
    {
        // fields 
        public string firstname;
        public string lastname;
        // properties
        public string Name
        {
            get { return firstname + " " + lastname; }
        }
        public string Address { get; set; }
        public bool Presence { get; set; }
        public string AddStudent { get; set; }
        // default? constructor
        // constructor
        // methods to change something
        // method to display something
        
        public void PrintData()
        {
            Console.WriteLine("Name: " + Name);
        }
        // destructor
    }
}
