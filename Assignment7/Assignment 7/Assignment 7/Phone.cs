using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_7
{
    public class Phone
    {
        public string CellPhone { get; set; }
        public string OfficePhone { get; set; }
        /// <summary>
        /// Default constructor - calls another constructor in this class
        /// </summary>
        public Phone()
        {
        }
        /// <summary>
        /// Constructor - calls another constructor in this class
        /// </summary>
        public Phone(string cellPhone, string officePhone)
        {
            CellPhone = cellPhone;
            OfficePhone = officePhone;
        }
        /// <summary>
        /// Delivers a formatted string with data stored in the object.
        /// </summary>
        public override string ToString()
        {
            string strOut = "\n" + "Phones" + "\n";
            strOut += string.Format(" {0,-10} {1, -10}\n", "Cell", CellPhone);
            strOut += string.Format(" {0,-10} {1, -10}\n\n", "Office", OfficePhone);
            return strOut;
        }
    }
}
