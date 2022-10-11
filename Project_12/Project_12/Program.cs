using System;
using System.Text;
using ClassLibrary;

namespace Project_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Person bill = new Person("Bill", "Wick");
            bill.DateOfBirth = new DateTime(1990, 1, 1);

            bill.SayHi();
            bill.ContactNumber = "111222333";
            Console.WriteLine(bill.ContactNumber);



            Person john = new Person(new DateTime(1990, 1, 2), "John", "Wick");

            john.SayHi();

            Console.WriteLine("Objects of Person type count : " + Person.Count);

            //          Examples of static elements:
            //
            //  1.static methods from Console:
            //
            //      Console.WriteLine();
            //      Console.WriteLine();
            //
            //  2. static property from DateTime:
            //
            //      DateTime.Now;
            //
            //  3. static method from int:
            // 
            //      int.Parse();
            //
            // ---------------------------------------

            ExcelFile excelFile = new ExcelFile();
            excelFile.CreatedOn = DateTime.Now;
            excelFile.FileName = "excel-file";
            excelFile.GenerateReport();

            WordDocumentFile wordDocFile = new WordDocumentFile();
            wordDocFile.CreatedOn = DateTime.Now;
            wordDocFile.FileName = "word-file";
            wordDocFile.Print();

            PowerPointFile powerPointFile = new PowerPointFile();
            powerPointFile.CreatedOn = DateTime.Now;
            powerPointFile.FileName = "powerpoint-file";
            powerPointFile.Present();

            Class1 test = new Class1();
            test.PublicProp = "test";
            //error test.InternalProp = "test";
            //error (abstract class) File file = new File();
            powerPointFile.Compress();

            Console.WriteLine("********************************");

            Shape[] shapes = { new Circle(), new Rectangle(), new Triangle(), new Square() };
            foreach (Shape shape in shapes) 
            {
                shape.Draw();
            }
        }
    }
}
