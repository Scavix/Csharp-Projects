using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Assignment_7
{
    public class Contact
    {
        public Email Email { get; set; } = new();
        public Address Address { get; set; } = new();
        public Phone Phone { get; set; } = new();
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        /// <summary>
        /// Basic Constructor
        /// </summary>
        public Contact()
        {
        }
        /// <summary>
        /// Constructor with all fields
        /// </summary>
        public Contact(string firstName, string lastName, Address address, Phone phone, Email email)
        {
            this.Email = email;
            this.Phone = phone;
            this.Address = address;
            this.FirstName = firstName;
            this.LastName = lastName;
        }
    }
}
