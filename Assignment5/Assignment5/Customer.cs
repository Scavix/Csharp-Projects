using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    public class Customer
    {
        public Contact contact { get; set;}
        public Customer(Contact contact)
        {
            this.contact = contact;
        }
    }
}
