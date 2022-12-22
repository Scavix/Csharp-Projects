using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    public class Contact
    {
        public Email email { get; set; }
        public Address address { get; set; }
        public Phone phone { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        /// <summary>
        /// Basic Constructor
        /// </summary>
        public Contact()
        {
            email = new Email();
            address = new Address();
            phone = new Phone();
            firstName = "";
            lastName = "";
        }
        /// <summary>
        /// Constructor throgh another contact
        /// </summary>
        public Contact(Contact theOther)
        {
            this.email = theOther.email;
            this.phone = theOther.phone;
            this.address = theOther.address;
            this.firstName = theOther.firstName;
            this.lastName = theOther.lastName;
        }
        /// <summary>
        /// Constructor with all fields
        /// </summary>
        public Contact(string firstName, string lastName, Address address, Phone phone, Email email)
        {
            this.email = email;
            this.phone = phone;
            this.address = address;
            this.firstName = firstName;
            this.lastName = lastName;
        }
    }
}
