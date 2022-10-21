using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
     public class Contact
    {
        public string Name { get; set; }
        public string PhoneNumber { get; set; }

        public Contact()
        {
            this.Name = "Null";
            this.PhoneNumber = "Null";
        }
        public Contact(string name, string number)
        {
            this.Name = name;
            this.PhoneNumber = number;
        }

    }
}
