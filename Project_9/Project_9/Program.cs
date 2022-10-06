using System;
using System.Text;

namespace Project_9
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] cars = { "Volvo", "BMW", "Mazda" };


            try
            {
                cars[4] = "Tesla"; // throws exception 
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("Index out of range!");
                // executed when exception "IndexOutOfRangeException" is caught
            }
            catch (Exception e)
            {
                Console.WriteLine("Unknown exception :(");
            }
            finally
            {
                Console.WriteLine("Some cleanup");
                // Always executed even with exepction
            }

            Console.WriteLine("Try-Catch ended!");
        }
    }
}