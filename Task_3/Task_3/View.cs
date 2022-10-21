using ClassLibrary;
using System.Xml.Linq;

namespace Task_3;

internal class View
{
    public void DisplayContacts(ContactBook book)
    {
        foreach (var element in book.Contacts)
        {
            Console.WriteLine($"Name: {element.Name}, Number: {element.PhoneNumber}");
        }
    }

    public void DisplayContact(Contact contact)
    {
        Console.WriteLine($"Name: {contact.Name}, Number: {contact.PhoneNumber}");
    }

    public void Menu()
    {
        Console.WriteLine("1. Add Contact");
        Console.WriteLine("2. Search");
        Console.WriteLine("3. Display All");
        Console.WriteLine("4. Exit");
    }


}