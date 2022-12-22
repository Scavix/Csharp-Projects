using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    public class Address
    {
        private string street;
        private string city;
        private string zip;
        private Countries country;
        /// <summary>
        /// Basic constructor.
        /// </summary>
        public Address()
        {
            street = "";
            city = "";
            zip= "";
            country = Countries.Sverige;
        }
        /// <summary>
        /// Constructor with four parameters.
        /// </summary>
        /// <param name="street">Input - address street</param>
        /// <param name="city">Input - address city</param>
        /// <param name="zip">Input - address zip</param>
        /// <param name="country">Input - address country</param>
        public Address(string street, string city, string zip, Countries country)
        {
            this.street = street;
            this.city = city;
            this.zip = zip;
            this.country = country;
        }
        /// <summary>
        /// Property related to the street field.
        /// </summary>
        public string Street
        {
            get { return street; }
            set { street = value; }
        }
        /// <summary>
        /// Property related to city field.
        /// </summary>
        public string City
        {
            get { return city; }
            set { city = value; }
        }
        /// <summary>
        /// Property related to zip field.
        /// </summary>
        public string Zip
        {
            get { return zip; }
            set { zip = value; }
        }
        /// <summary>
        /// Property related to the country field.
        /// </summary>
        public Countries Country
        {
            get { return country; }
            set { country = value; }
        }
        /// <summary>
        /// This method prepares a format string that is in sync with the ToString method.
        /// </summary>
        public string GetToStringItemsHeadings
        {
            get { return string.Format("{0,-20} {1, -20} {0,-20} {1, -20}", "Street", "City", "Zip", "Country"); }
        }
        /// <summary>
        /// Delivers a formatted string with data stored in the object.
        /// </summary>
        public override string ToString()
        {
            string strOut = "\n" + "Address" + "\n";
            strOut += string.Format(" {0,-10} {1, -10}\n", "Street", street);
            strOut += string.Format(" {0,-10} {1, -10}\n", "City", city);
            strOut += string.Format(" {0,-10} {1, -10}\n", "Zip", zip);
            strOut += string.Format(" {0,-10} {1, -10}\n", "Country", country);
            return strOut;
        }
    }
}
