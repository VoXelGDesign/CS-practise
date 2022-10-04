using System;
using System.Text;


namespace FifthProject
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] cars = { "Volvo", "BMW", "Nissan" };

            Console.WriteLine(cars[0]);
            int arrayLength = cars.Length; // 3
            cars[2] = "Tesla";

            Console.WriteLine(cars[arrayLength - 1]);
        }
    }
}
