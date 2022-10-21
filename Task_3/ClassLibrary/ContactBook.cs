using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class ContactBook
    {
        public List<Contact> Contacts { get; set; }

        public ContactBook()
        {
            Contacts = new List<Contact>();
        }
        public void Add(string? name, string? number)
        {
            Contacts.Add(new Contact(name,number));
        }

        public Contact? SearchByNumber(string number)
        {
            var searchedContact = Contacts.FirstOrDefault(c => c.PhoneNumber == number);
            return searchedContact;
        }

        public List<Contact> ReturnAll()
        {
            return Contacts.ToList();
        }

        public Contact? SearchByName(string name)
        {
            var searchedContact = Contacts.FirstOrDefault(c => c.Name == name);
            return searchedContact;
        }

    }
}
