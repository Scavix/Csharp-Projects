using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_7
{
    public class LoginManager
    {
        private List<LoginInfo> loginInfoList = new();
        private FileManager fileManager { get; set; } = new();
        /// <summary>
        /// Basic contructor that reads from file
        /// </summary>
        public LoginManager()
        {
            fileManager = new();
            List<UserLoginInfo> userLoginInfoList = new();
            if (!fileManager.ReadUserLoginInfoData(userLoginInfoList))
            {
                MessageBox.Show("Problem in reading user data","Error");
            }
            UsersLoginInfosManager usersLoginInfosManager = new(userLoginInfoList);
            loginInfoList = usersLoginInfosManager.GetLoginInfoList();
        }
        /// <summary>
        /// Login method
        /// </summary>
        /// <param name="username">username</param>
        /// <param name="password">password</param>
        /// <returns></returns>
        public bool Login(string username, string password)
        {
            if (username == "admin" && password == "password")
            {
                return true;
            }
            if (username == "user" && password == "password")
            {
                return true;
            }
            for (int i = 0; i < loginInfoList.Count; i++)
            {
                if (loginInfoList[i].Username == username && loginInfoList[i].Password == password)
                {
                    return true;
                }
            }
            return false;
        }
        /// <summary>
        /// Check if user is admin from its ID
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public bool IsAdmin(string userId)
        {
            if (userId == "0000")
            {
                return true;
            }
            for (int i = 0; i < loginInfoList.Count; i++)
            {
                if (loginInfoList[i].UserId == userId)
                {
                    return loginInfoList[i].UserType == UserTypes.Administrator;
                }
            }
            return false;
        }
        /// <summary>
        /// return userId from username and passwrod
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public string GetUserId(string username, string password)
        {
            if (username == "admin" && password == "password")
            {
                return "0000";
            }
            if (username == "user" && password == "password")
            {
                return "0001";
            }
            for (int i = 0; i < loginInfoList.Count; i++)
            {
                if (loginInfoList[i].Username == username && loginInfoList[i].Password == password)
                {
                    return loginInfoList[i].UserId;
                }
            }
            return "0001";
        }
        /// <summary>
        /// Check if user is admin from username and password
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public bool IsAdmin(string username, string password)
        {
            if (username == "admin" && password == "password")
            {
                return true;
            }
            for (int i = 0; i < loginInfoList.Count; i++)
            {
                if (loginInfoList[i].Username == username && loginInfoList[i].Password == password)
                {
                    return IsAdmin(loginInfoList[i].UserId);
                }
            }
            return false;
        }
    }
}
