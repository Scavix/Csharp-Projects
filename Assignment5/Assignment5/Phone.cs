using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    public class Phone
    {
        //cell phone
        private string cellPhone;
        //home phone
        private string homePhone;
        /// <summary>
        /// Default constructor - calls another constructor in this class
        /// </summary>
        public Phone()
        {
        }
        /// <summary>
        /// Constructor with one parameter - calls the constructor with 
        /// two parameters, using a default value as the second argument.
        /// </summary>
        /// <param name="cellPhone">input coming from the client object</param>
        public Phone(string cellPhone) : this(cellPhone, string.Empty)
        {
        }
        /// <summary>
        /// Copy constructor returning copy
        /// </summary>
        public Phone(Phone theOther)
        {
            this.cellPhone = theOther.cellPhone;
            this.homePhone = theOther.homePhone;
        }
        /// <summary>
        /// Constructor with two parameters. This is  constructor that has most
        /// number of parameters. It is in tis constructor that all coding 
        /// should be done.
        /// </summary>
        /// <param name="homePhone">Input - home phone</param>
        /// <param name="cellPhone">Input - cell phone</param>
        public Phone(string homePhone, string cellPhone)
        {
            this.homePhone = homePhone;
            this.cellPhone = cellPhone;
        }
        /// <summary>
        /// Property related to the cellPhone field.
        /// </summary>
        public string Cell
        {
            get { return cellPhone; }
            set { cellPhone = value; }
        }
        /// <summary>
        /// Property related to homePhone field.
        /// </summary>
        public string Home
        {
            get { return homePhone; }
            set { homePhone = value; }
        }
        /// <summary>
        /// This method prepares a format string that is in sync with the ToString method.
        /// </summary>
        public string GetToStringItemsHeadings
        {
            get { return string.Format("{0,-20} {1, -20}", "Office PhoneData", "Home PhoneData"); }
        }
        /// <summary>
        /// Delivers a formatted string with data stored in the object.
        /// </summary>
        public override string ToString()
        {
            string strOut = "\n" + "Phones" + "\n";
            strOut += string.Format(" {0,-10} {1, -10}\n", "Cell", cellPhone);
            strOut += string.Format(" {0,-10} {1, -10}\n\n", "Home", homePhone);
            return strOut;
        }
    }
}
