using System;
using System.Text;

namespace Project_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Person bill = new Person("Bill","Wick");
            bill.SetDateOfBirth(new DateTime(1990,1,1));          
            bill.SayHi();

            Person john = new Person(new DateTime(1990,1,2),"John","Wick");

            john.SayHi();
        }
    }
}
