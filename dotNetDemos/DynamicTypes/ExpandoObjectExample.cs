using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicTypes
{
    class ExpandoObjectExample
    {
        public static void Main()
        {
        dynamic contact = new ExpandoObject();
        contact.Name = "ABC";
        contact.Phone = "12345";
        contact.Address = new ExpandoObject();
        contact.Address.Street = "123";
        contact.Address.City = "Bangalore";
        contact.Address.State = "Karnataka";
        contact.Address.Postal = "560067";

        Console.WriteLine(contact.Address.State);
        }
    }
}
