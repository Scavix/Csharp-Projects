using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_7
{
    public class Address
    {
        public string Street { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string Zip { get; set; } = string.Empty;
        public Countries Country { get; set; } = Countries.Sverige;
        /// <summary>
        /// Basic constructor.
        /// </summary>
        public Address()
        {
        }
        /// <summary>
        /// Constructor with four parameters.
        /// </summary>
        /// <param name="street">Input - Address street</param>
        /// <param name="city">Input - Address city</param>
        /// <param name="zip">Input - Address zip</param>
        /// <param name="country">Input - Address country</param>
        public Address(string street, string city, string zip, Countries country)
        {
            this.Street = street;
            this.City = city;
            this.Zip = zip;
            this.Country = country;
        }
        /// <summary>
        /// Delivers a formatted string with data stored in the object.
        /// </summary>
        public override string ToString()
        {
            string strOut = "\n" + "Address" + "\n";
            strOut += string.Format(" {0,-10} {1, -10}\n", "Street", Street);
            strOut += string.Format(" {0,-10} {1, -10}\n", "City", City);
            strOut += string.Format(" {0,-10} {1, -10}\n", "Zip", Zip);
            strOut += string.Format(" {0,-10} {1, -10}\n", "Country", Country);
            return strOut;
        }
    }
}
