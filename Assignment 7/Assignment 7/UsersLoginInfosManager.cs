using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_7
{
    internal class UsersLoginInfosManager
    {
        public List<UserLoginInfo> UserLoginInfoList { get; set; } = new();
        /// <summary>
        /// Basic constructor
        /// </summary>
        public UsersLoginInfosManager() { }
        /// <summary>
        /// Basic constructor
        /// </summary>
        /// <param name="uli">UserLoginInfo list</param>
        public UsersLoginInfosManager(List<UserLoginInfo> uli)
        {
            UserLoginInfoList = new();
            for (int i = 0; i < uli.Count; i++)
            {
                UserLoginInfoList.Add(uli[i]);
            }
        }
        /// <summary>
        /// Method to retrieve list
        /// </summary>
        public List<UserLoginInfo> GetUserLoginInfoList()
        {
            return UserLoginInfoList;
        }
        /// <summary>
        /// Method to get the UserLoginInfo at i index from list
        /// </summary>
        /// <param name="i">index</param>
        public UserLoginInfo GetUserLoginInfo(int i)
        {
            return UserLoginInfoList[i];
        }
        /// <summary>
        /// Method to add a UserLoginInfo to the list
        /// </summary>
        /// <param name="uli">UserLoginInfo to be added</param>
        public void AddUserLoginInfo(UserLoginInfo uli)
        {
            UserLoginInfoList.Add(uli);
        }
        /// <summary>
        /// Method to remove a UserLoginInfo from the list
        /// </summary>
        /// <param name="index">UserLoginInfo index to be removed</param>
        public void RemoveCity(int index)
        {
            UserLoginInfoList.RemoveAt(index);
        }
        /// <summary>
        /// Method to swap a UserLoginInfo to the list
        /// </summary>
        /// <param name="uli">UserLoginInfo to be added</param>
        /// <param name="index">Index to be swapped</param>
        public void ChangeUserLoginInfo(UserLoginInfo uli, int index)
        {
            UserLoginInfoList[index] = uli;
        }
        /// <summary>
        /// Return all logininfos in a list
        /// </summary>
        public List<LoginInfo> GetLoginInfoList()
        {
            List<LoginInfo> result = new();
            for (int i = 0; i < UserLoginInfoList.Count; i++ )
            {
                result.Add(UserLoginInfoList[i].LoginInfo);
            }
            return result;
        }
        /// <summary>
        /// Return all users in a list
        /// </summary>
        public List<User> GetUserList()
        {
            List<User> result = new();
            for (int i = 0; i < UserLoginInfoList.Count; i++)
            {
                result.Add(UserLoginInfoList[i].User);
            }
            return result;
        }
        /// <summary>
        /// Method to get the user at i index from list
        /// </summary>
        /// <param name="i">index</param>
        public User GetUser(int i)
        {
            return UserLoginInfoList[i].User;
        }
        /// <summary>
        /// Method to add a user to the list
        /// </summary>
        /// <param name="u">User to be added</param>
        public void AddUser(User u)
        {
            if (u.UserId == "----")
            {
                Random rnd = new();
                u.UserId = rnd.Next(1000, 9999).ToString();
            }
            LoginInfo li = new(u.UserId,"username"+u.UserId,"password"+u.UserId,u.UserType);
            UserLoginInfoList.Add(new(u,li));
        }
        /// <summary>
        /// Method to remove a user from the list
        /// </summary>
        /// <param name="userIndex">User index to be removed</param>
        public void RemoveUser(int userIndex)
        {
            UserLoginInfoList.RemoveAt(userIndex);
        }
        /// <summary>
        /// Method to swap a user to the list
        /// </summary>
        /// <param name="u">user to be added</param>
        /// <param name="index">Index to be swapped</param>
        public void ChangeUser(User u, int index)
        {
            UserLoginInfoList[index].User.UserId = u.UserId;
            UserLoginInfoList[index].User.UserId = u.UserId;
            UserLoginInfoList[index].User.Contact.FirstName = u.Contact.FirstName;
            UserLoginInfoList[index].User.Contact.LastName = u.Contact.LastName;
            UserLoginInfoList[index].User.Contact.Phone.OfficePhone = u.Contact.Phone.CellPhone;
            UserLoginInfoList[index].User.Contact.Phone.CellPhone = u.Contact.Phone.OfficePhone;
            UserLoginInfoList[index].User.Contact.Email.OfficeMail = u.Contact.Email.OfficeMail;
            UserLoginInfoList[index].User.Contact.Email.PersonalMail = u.Contact.Email.PersonalMail;
            UserLoginInfoList[index].User.Contact.Address.City = u.Contact.Address.City;
            UserLoginInfoList[index].User.Contact.Address.Country = u.Contact.Address.Country;
            UserLoginInfoList[index].User.Contact.Address.Zip = u.Contact.Address.Zip;
            UserLoginInfoList[index].User.Contact.Address.Street = u.Contact.Address.Street;
            UserLoginInfoList[index].User.UserType = u.UserType;
        }
        /// <summary>
        /// Check duplicate
        /// </summary>
        /// <param name="s">string with id</param>
        public bool CheckId(string s)
        {
            List<User> userList = GetUserList();
            for (int i = 0; i < userList.Count; i++)
            {
                if (userList[i].UserId == s)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
