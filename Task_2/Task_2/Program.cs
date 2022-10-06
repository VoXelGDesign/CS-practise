using System;
using System.Text;


namespace Task_2
{
    class Program
    {
        
        /// Task two - write program that calculate days elapsed 
        /// since entered date
        
        static void Main(string[] args)
        {
            
            
           Console.WriteLine("Enter your date of birth :");
           DateTime date;
           if (!DateTime.TryParse(Console.ReadLine(), out date))
           {
                Console.WriteLine("Invalid Date!");
           }
           else
           {
                Console.WriteLine("Days Elapsed: " + ((int)DateTime.Now.Subtract(date).TotalDays));
           }
                
        }
    }
}