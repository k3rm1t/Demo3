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
        public void Add()
        {
            Console.WriteLine("Add new student. Write first name:");
            firstname = Console.ReadLine();
            Console.WriteLine("Last name: ");
            lastname = Console.ReadLine();
            Console.WriteLine("Stident Id:");
            StudentId = Console.ReadLine();
            Console.WriteLine("Address: ");
            Address = Console.ReadLine();
        }
        // method to display something
        
        public string this[int i]
        {
            get
            {
                return strings[i];
            }
            set
            {
                strings[i] = Name +" "+ StudentId+"\n" + Address + "\n" ;
            }
            
        }
        public void PrintData()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Student Id: " + StudentId);
            Console.WriteLine("Precense: " + Presence);
            
            
        }
        // destructor
        ~Student()
        {
            Console.WriteLine("Object destroyed.");
        }
    }
}
