using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_7
{
    public class LoginInfo
    {
        /// <summary>
        /// generic user 0001 userid
        /// generic admin 0000 userid
        /// </summary>
        public string UserId { get; set; } = string.Empty;
        public string Username { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public UserTypes UserType { get; set; } = UserTypes.Administrator;
        /// <summary>
        /// Basic constructor
        /// </summary>
        public LoginInfo()
        {
        }
        /// <summary>
        /// Full constructor
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <param name="userType"></param>
        public LoginInfo(string userId, string username, string password, UserTypes userType)
        {
            Username = username;
            Password = password;
            UserType = userType;
            UserId = userId;
        }
    }
}
