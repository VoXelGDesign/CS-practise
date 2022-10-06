using Project_7;
using System;
using System.Text;


namespace Prjoect_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your gender?   1 - Male, 2 - Female");
            string inp = Console.ReadLine();

            Gender userGender = (Gender)Enum.Parse(typeof(Gender), inp);

            if(userGender == Gender.Male)
            {
                Console.WriteLine("Male was selected");
            }
            else
            {
                Console.WriteLine("Female was selected");
            }
        }
    }
}