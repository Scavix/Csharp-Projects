using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_7
{
    public class Email
    {
        //private Email
        public string PersonalMail { get; set; }
        //officeMail mail
        public string OfficeMail { get; set; }
        /// <summary>
        /// Default constructor - calls another constructor in this class
        /// </summary>
        public Email()
        {
        }
        /// <summary>
        /// Default constructor - calls another constructor in this class
        /// </summary>
        public Email(string personalEmail, string officeEmail)
        {
            PersonalMail = personalEmail;
            OfficeMail = officeEmail;
        }
        /// <summary>
        /// Delivers a formatted string with data stored in the object. The values will
        /// appear as columns.  Make sure that a font like "Courier New" is used in
        /// the control displaying this information.
        /// </summary>
        public override string ToString()
        {
            string strOut = "\n" + "Emails" + "\n";

            strOut += string.Format(" {0,-10} {1, -10}\n", "Private", PersonalMail);
            strOut += string.Format(" {0,-10} {1, -10}\n\n", "Office", OfficeMail);

            return strOut;
        }
    }
}
