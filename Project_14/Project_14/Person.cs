using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_14
{
    internal class Person
    {
        public string firstName { get; set; }
        public string lastName { get; set; }

        private DateTime dateOfBirth;
        public DateTime DateOfBirth
        {
            get => dateOfBirth;
            set { dateOfBirth = value; }
        }

        private string? phoneNumber;
        
        public string PhoneNumber
        {
            get => phoneNumber;
            set
            {
                if (value.Length == 9) phoneNumber = value;
                else Console.WriteLine("Invalid number!");
            }
        }

        public static int Count = 0;

        public Person(string firstName, string lastName, DateTime dateOfBirth)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.dateOfBirth = dateOfBirth;
            Count++;
        }
        public Person(string fName, string lName, DateTime dOfBirth, string phoneNumber) : this(fName, lName, dOfBirth)
        {           
            this.phoneNumber = phoneNumber;
        }

        
        public void SayHi()
        {
            Console.WriteLine($"Hi I'm {this.firstName} {this.lastName}, {this.dateOfBirth}, Number: {this.phoneNumber}");
        }

    }
}
