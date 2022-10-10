using System;
using System.Text;

namespace Project_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Person bill = new Person("Bill","Wick");
            bill.DateOfBirth = new DateTime(1990,1,1);

            bill.SayHi();
            bill.ContactNumber = "111222333";
            Console.WriteLine(bill.ContactNumber);

            

            Person john = new Person(new DateTime(1990,1,2),"John","Wick");

            john.SayHi();
        }
    }
}
