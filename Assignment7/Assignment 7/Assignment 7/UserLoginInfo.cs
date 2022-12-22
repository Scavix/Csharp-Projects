using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_7
{
    public class UserLoginInfo
    {
        public User User { get; set; }
        public LoginInfo LoginInfo { get; set; }
        public UserLoginInfo(User user, LoginInfo loginInfo)
        {
            User = user;
            LoginInfo = loginInfo;
        }
    }
}
