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
        public string[] strings = new string[5];
        public string firstname;
        public string lastname;
        // properties
        public string Name
        {
            get { return firstname + " " + lastname; }
        }
        public string Address { get; set; }
        public string StudentId { get; set; }
        public bool Presence { get; set; }
        public string AddStudent { get; set; }
        // default? constructor
        // constructor
        // methods to change something
        // method to display something
        
        public string this[int i]
        {
            get
            {
                return strings[i];
            }
            set
            {
                strings[i] = Name +"\n"+ Address + "\n" + StudentId;
            }
            //Data[0] =  firstname +"\n" + lastname + "\n" + StudentId + "\n" + Address;
        }
        public void PrintData()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Student Id: " + StudentId);
            Console.WriteLine("Precense: " + Presence);
            
            //Console.WriteLine("Info: " + Data[0]);
        }
        // destructor
        ~Student()
        {
            Console.WriteLine("Object destroyed.");
        }
    }
}
