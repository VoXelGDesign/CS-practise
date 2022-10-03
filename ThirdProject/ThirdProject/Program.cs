using System;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Channels;

namespace Program
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Input year of birth");
            string userInput = Console.ReadLine();

            int yearOfBirth = int.Parse(userInput);
            bool isUserOver18 = DateTime.Now.Date.Year - yearOfBirth > 18;

            if (isUserOver18)
            {
                Console.WriteLine("hello");
            }
            else if(DateTime.Now.Year - 18 == yearOfBirth)
            {
                Console.WriteLine("Oh well, you've just turned 18");
            }
            else
            {
                Console.WriteLine("Access Denied");
            }

            Console.WriteLine("Bye");

            Console.WriteLine("****************************");


            switch (DateTime.Now.DayOfWeek)
            {
                case DayOfWeek.Monday:
                    Console.WriteLine("It's Monday");
                    break;

                case DayOfWeek.Friday:
                    Console.WriteLine("It's Friday");
                    break;

                case DayOfWeek.Saturday:
                case DayOfWeek.Sunday:
                    Console.WriteLine("Weekend!");
                    break;

                default:
                    Console.WriteLine("Middle of the Week");
                    break;

            }

        }

    }
}