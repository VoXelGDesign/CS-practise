using System;

namespace SecondProject;

class Program
{
    static void Main(string[] args)
    {
        // Common Operators

        int result;
        int x = 10;
        int y = 5;

            //Numerical Operators
            result = (x+y);
            Console.WriteLine("Addition Operator for x and y = " + result);
        
            result = (x-y);
            Console.WriteLine("Substraction Operator for x and y = " + result);
        
            result = (x * y);
            Console.WriteLine("Multiplication Operator for x and y = " + result);
        
            result = (x / y);
            Console.WriteLine("Division Operator for x and y = " + result);

            result = (x % y);
            Console.WriteLine("Modulo Operator for x and y = " + result);

            int value1 = 2 + 2 * 5; // 12
            int value2 = (2 + 2) * 5; // 20

            value1 = 10;
            value2 = 10;

            Console.WriteLine("****************************");

            Console.WriteLine("Pre-increment result : ");
            Console.WriteLine(++value1);

            Console.WriteLine("Post-increment result : ");
            Console.WriteLine(value2++);
            Console.WriteLine(value2);
            //

        Console.WriteLine("****************************");

        bool boolResult;
        x = 2;
        y = 10;

            // Comaprison Operators
            boolResult = (x == y);
            Console.WriteLine("Equal Operator for x and y = " + boolResult);

            boolResult = (x > y);
            Console.WriteLine("Grater Operator for x and y = " + boolResult);

            boolResult = (x < y);
            Console.WriteLine("Less Operator for x and y = " + boolResult);

            boolResult = (x >= y);
            Console.WriteLine("Grater than or Equal Operator for x and y = " + boolResult);

            boolResult = (x <= y);
            Console.WriteLine("Less than or Equal Operator for x and y = " + boolResult);

            boolResult = (x != y);
            Console.WriteLine("Not Equal Operator for x and y = " + boolResult);
            //

        Console.WriteLine("****************************");

        bool a = true;
        bool b = false;

            // Logical Operators
            boolResult = a && b;
            Console.WriteLine("AND Operator for a and b = " + boolResult);

            boolResult = a || b;
            Console.WriteLine("OR Operator for a and b = " + boolResult);

            boolResult = !a;
            Console.WriteLine("NOT Operator for a = " + boolResult);
            //

        Console.WriteLine("****************************");
        x = 5;
        y = 10;

            //Ternary Operator
            int greaterNum = x>y ? x : y;
            Console.WriteLine("Ternary Operator for x > y ? x : y = " + greaterNum); 
            // first argument - logical operator , second - returned value when true, third - returned value when false
            //


        //
    }
}

