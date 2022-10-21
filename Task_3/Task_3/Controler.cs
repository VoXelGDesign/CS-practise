using System.Diagnostics;
using System.Text.RegularExpressions;
using ClassLibrary;
namespace Task_3;

/// <summary>
/// Phone contact book console application, where you can add contact , search by number, or display all contacts.
/// User input correctness checked by regex.
/// MVC model (app to small to be useful, but just for training)
/// </summary>

//comments will be added

internal class Controler
{
     
     
    private static void Main(string[] args)
    {
        ContactBook bookOfContacts = new ContactBook();
        View mainView = new View();

        var nameRegex = new Regex("[a-zA-z]{2}"); 
        var numberRegex = new Regex("[0-9]{9,13}");
        var rx = new Regex("[0-9]");
        var end = false;

        while (!end)
        {
            Console.Clear();
            
            mainView.Menu();
            var menuOption = -1;
            
            if(!int.TryParse(Console.ReadLine(), out menuOption))
            {
                Console.WriteLine("Invalid input!");
            }

            switch (menuOption)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("Input name:");
                    var userInputName = Console.ReadLine();
                    Console.WriteLine("Input number:");
                    var userInputNumber = Console.ReadLine();

                    if (nameRegex.IsMatch(userInputName) && numberRegex.IsMatch(userInputNumber))
                        bookOfContacts.Add(userInputName, userInputNumber);
                    else Console.WriteLine("Invalid data format");


                    Console.ReadKey();
                    break;

                case 2:
                    if(bookOfContacts.Contacts.Any())
                    {
                        Console.Clear();
                        Console.WriteLine("Input name or number:");
                        var userInput = Console.ReadLine();
                        mainView.DisplayContact(rx.IsMatch(userInput) ? bookOfContacts.SearchByNumber(userInput) : bookOfContacts.SearchByName(userInput));
                        
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("No contacts to search!");
                    }
                    Console.ReadKey();
                    break;
                case 3:
                    Console.Clear();
                    mainView.DisplayContacts(bookOfContacts);
                    Console.ReadKey();
                    break;
                case 4:
                    end = true;
                    break;

            }
        }
    }

    
}