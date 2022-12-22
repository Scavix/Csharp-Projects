using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_7
{
    public class User
    {
        public string UserId { get; set; } = string.Empty;
        public Contact Contact { get; set; } = new();
        public UserTypes UserType { get; set; } = UserTypes.User;
        /// <summary>
        /// Default constructor
        /// </summary>
        public User() { }
        /// <summary>
        /// Entire constructor
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="userName"></param>
        /// <param name="contact"></param>
        /// <param name="userType"></param>
        public User(string userId, Contact contact, UserTypes userType) {
            UserId = userId;
            Contact = contact;
            UserType = userType;
        }
    }
}
