using System;
using System.Text;

namespace FirstProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type Name:");    //
            string name = Console.ReadLine();   // console interaction
            Console.WriteLine("Hello " + name); //

            // valuable variable types

                string text = "some text";
                char letter = 'a';
                char Unicode = '\u00F8';
                bool isReady = true;
                DateTime now = DateTime.Now;
                DateTime date = new DateTime(2000, 6, 1);
                byte byteValue = 200;
                float floatValue = 1.5f;
                decimal decimalValue = 1.5m;
                double doubleValue = 1.5;

            //

            // string
                
                // First Example
                string exampleOne;
                // Console.WriteLine(exampleOne); error
                exampleOne = "first text";
                Console.WriteLine(exampleOne);
                //

                // Second Example
                string exampleTwo = null;
                Console.WriteLine(exampleTwo);
                //

                // Third Example
                string exampleThree = string.Empty; // not the same as null
                //

                // Forth Example
                string exampleFour = "some text \"Text\"";
                    Console.WriteLine(exampleFour);
                string path = "c:\\windows";
                    Console.WriteLine(path);
                string secondPath = @"c:\windows\users";
                    Console.WriteLine(secondPath);
                //

                //Fifth Example
                string concat = string.Concat(text, "is", "here");
                    Console.WriteLine(concat);
                string concat2 = text + "is" + "here";
                    Console.WriteLine(concat2);
                string interpolated = $"{text} is here";
                    Console.WriteLine(interpolated);
                //

                //String Builder
                StringBuilder strBuilder = new StringBuilder("This");
                strBuilder.Append("is");
                strBuilder.Append("long");
                strBuilder.Append("string");
                string result = strBuilder.ToString();
                    Console.WriteLine(result);
                //
        }
    }
}

