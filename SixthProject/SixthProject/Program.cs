using System;
using System.Text;

namespace SixthProject
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] cars = { "Volvo", "Bmw", "Mazda" };
            int i = 0;
            // While Loop
                while(i < cars.Length)
                {
                    Console.WriteLine(cars[i]);
                    if (cars[i] == "Bmw")
                    {
                        Console.WriteLine("Bye");
                            break;
                    }
                    i++;
                }
            //

            Console.WriteLine("To exit type 'x'");
            string inp;

            // Do-While Loop
                do
                {
                    inp = Console.ReadLine();
                    Console.WriteLine($"Echo: {inp}");
                } while (inp != "x");
            //

            Console.WriteLine("******************");

            //For Loop
                for(int j = 0; j < cars.Length; j++)
                {
                    Console.WriteLine(cars[j]);
                    if (cars[j] == "Bmw")
                    {
                        Console.WriteLine("Bye");
                        break;
                    }
                }
            //

            Console.WriteLine("******************");

            //Foreach Loop
                foreach(string car in cars)
                {
                    Console.WriteLine(car);
                    if(car == "Bmw")
                    {
                        Console.WriteLine("Bye");
                        break;
                    }
                }
            //
        }
    }
}