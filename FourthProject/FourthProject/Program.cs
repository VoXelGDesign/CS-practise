using System;
using System.Text;


namespace FourthProject
{
    class Program
    {
        static void Main(string[] args)
        {
            byte bValue = 100;
            int iValue = bValue;
            byte bValue2 = (byte)iValue;
            double dValue = 3.5;
            int iValue2 = (int)dValue;

            string sValue2 = iValue2.ToString();

            string userInput = Console.ReadLine();
            int yearOfBirth;

            if(int.TryParse(userInput, out yearOfBirth))
            {
                int age = DateTime.Now.Year - yearOfBirth;

                Console.WriteLine("Your Age: " + age);
            }
            else
            {
                Console.WriteLine("Incorrect Value");
            }
           

        }
    }
}