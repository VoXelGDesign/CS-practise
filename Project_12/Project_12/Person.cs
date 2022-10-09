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

        public Person(string firstName, string lastName)
        {
            Console.WriteLine("Construktor1");
            FirstName = firstName;
            LastName = lastName;
        }
        public Person(DateTime dateOfBirth,string firstName, string lastName) : this(firstName, lastName)
        {
            Console.WriteLine("Construktor2");
            SetDateOfBirth(dateOfBirth);
        }
        public void SetDateOfBirth(DateTime date)
        {
            if (date < DateTime.Now) dateOfBirth = date;
            else Console.WriteLine("Invalid date of Birth!");
        }

        public DateTime GetDateOfBirth() => dateOfBirth; // or older version public DateTime GetDateOfBirth(){ return dateOfBirth;}
        public void SayHi()
        {
            Console.WriteLine($"Hi, I'm {this.FirstName}, {this.GetDateOfBirth()}");
        }
    }
}
