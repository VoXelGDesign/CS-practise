using System;
using System.Text;


namespace FirstTask
{
    class Program
    {
        static void Main(string[] args)
        {
            ///
            /// First Task
            /// Create console app , which takes user numbers, until user enters 0
            /// App should add all elements and find the biggest number
            /// When 0 is entered , this two values should be displayed
            ///

            int sum = 0;
            int biggestValue = 0;

            while (true)
            {
                Console.WriteLine("Enter number: ");
                int inp;
                if(!int.TryParse(Console.ReadLine(), out inp))
                {
                    Console.WriteLine("Invalid input!");
                }
                else if (inp == 0)
                {
                    Console.WriteLine("Sum = " + sum + ", Greatest number = " + biggestValue);
                    break;
                }
                else
                {
                    sum += inp;
                    if(inp > biggestValue) biggestValue = inp;
                }

            }
        }
    }
}