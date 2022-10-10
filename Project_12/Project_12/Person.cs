using System;
using System.Collections.Generic;
using System.Text;

namespace Project_12
{
    class Person
    {
        public string FirstName;
        public string LastName;
        private DateTime dateOfBirth;

        private string contactNumber;

        public string ContactNumber
        {
            get { return contactNumber; }
            set 
            {
                if (value.Length < 9) Console.WriteLine("Invalid contact number!");
                else contactNumber = value;
            }
        }


        public Person(string firstName, string lastName)
        {
            Console.WriteLine("Construktor1");
            FirstName = firstName;
            LastName = lastName;
        }
        public Person(DateTime dateOfBirth,string firstName, string lastName) : this(firstName, lastName)
        {
            Console.WriteLine("Construktor2");
            DateOfBirth = dateOfBirth;
        }

        public DateTime DateOfBirth
        {
            get { return dateOfBirth; }
            set 
            {
                if (value < DateTime.Now) dateOfBirth = value;
                else Console.WriteLine("Invalid date of Birth!");
            }
        }
       
        public void SayHi()
        {
            Console.WriteLine($"Hi, I'm {this.FirstName}, {this.DateOfBirth}");
        }
    }
}
