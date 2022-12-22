using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_7
{
    public class FileManager
    {
        private const string fileNameUsersData = "./Data/usersData.txt";
        private const string fileNameRoutesData = "./Data/routesData.txt";
        private const string fileVersionToken = "Assignment7_2022";
        private const int fileVersionNr = 1;
        private const string fileAuthor = "FrancescoScavello";
        public FileManager()
        {
            if (!Directory.Exists("./Data"))
            {
                Directory.CreateDirectory("./Data");
            }
            if (!Directory.Exists("./Tickets"))
            {
                Directory.CreateDirectory("./Tickets");
            }
        }
        /// <summary>
        /// Method to read a file and import user data
        /// </summary>
        public bool ReadUserLoginInfoData(List<UserLoginInfo> userLoginInfoList)
        {
            bool ok = true;
            StreamReader reader = null;
            try
            {
                if (userLoginInfoList != null)
                {
                    userLoginInfoList.Clear();
                }
                else
                {
                    userLoginInfoList = new();
                }
                if (!File.Exists(fileNameUsersData))
                {
                    return true;
                }
                reader = new StreamReader(fileNameUsersData);
                string versionTest = reader.ReadLine();
                double version = int.Parse(reader.ReadLine());
                string author = reader.ReadLine();
                if ((versionTest == fileVersionToken) && (version == fileVersionNr) && (author == fileAuthor))
                {
                    int count = int.Parse(reader.ReadLine());
                    for (int i = 0; i < count; i++)
                    {
                        LoginInfo loginInfo = new();
                        loginInfo.UserId = reader.ReadLine();
                        loginInfo.Username = reader.ReadLine();
                        loginInfo.Password = reader.ReadLine();
                        string firstname = string.Empty;
                        string lastname = string.Empty;
                        string officePhone = string.Empty;
                        string cellPhone = string.Empty;
                        string officeEmail = string.Empty;
                        string personalEmail = string.Empty;
                        string street = string.Empty;
                        string city = string.Empty;
                        string zip = string.Empty;
                        Countries country = new();
                        Phone phone = new();
                        Email email = new();
                        Address address = new();
                        User user = new();
                        user.UserId = loginInfo.UserId;
                        firstname = reader.ReadLine();
                        lastname = reader.ReadLine();
                        officePhone = reader.ReadLine();
                        cellPhone = reader.ReadLine();
                        officeEmail = reader.ReadLine();
                        personalEmail = reader.ReadLine();
                        street = reader.ReadLine();
                        city = reader.ReadLine();
                        zip = reader.ReadLine();
                        country = (Countries)Enum.Parse(typeof(Countries), reader.ReadLine());
                        user.Contact = new(firstname, lastname, new Address(street, city, zip, country), new Phone(cellPhone, officePhone), new Email(personalEmail, officeEmail));
                        user.UserType = (UserTypes)Enum.Parse(typeof(UserTypes), reader.ReadLine());
                        loginInfo.UserType = user.UserType;
                        userLoginInfoList.Add(new(user, loginInfo));
                    }
                }
                else
                {
                    ok = false;
                }
            }
            catch
            {
                ok = false;
            }
            finally
            {
                if (reader != null)
                {
                    reader.Close();
                }
            }
            return ok;
        }
        /// <summary>
        /// Method to save all user data to file
        /// </summary>
        /// <param name="userList">user data to save</param>
        /// <returns></returns>
        public bool WriteUserLoginInfoDataToFile(List<UserLoginInfo> userLoginInfoList)
        {
            bool ok = true;
            StreamWriter writer = null;
            try
            {
                writer = new StreamWriter(fileNameUsersData);
                writer.WriteLine(fileVersionToken);
                writer.WriteLine(fileVersionNr);
                writer.WriteLine(fileAuthor);
                writer.WriteLine(userLoginInfoList.Count);
                for (int i = 0; i < userLoginInfoList.Count; i++)
                {
                    writer.WriteLine(userLoginInfoList[i].User.UserId);
                    writer.WriteLine(userLoginInfoList[i].LoginInfo.Username);
                    writer.WriteLine(userLoginInfoList[i].LoginInfo.Password);
                    writer.WriteLine(userLoginInfoList[i].User.Contact.FirstName);
                    writer.WriteLine(userLoginInfoList[i].User.Contact.LastName);
                    writer.WriteLine(userLoginInfoList[i].User.Contact.Phone.OfficePhone);
                    writer.WriteLine(userLoginInfoList[i].User.Contact.Phone.CellPhone);
                    writer.WriteLine(userLoginInfoList[i].User.Contact.Email.OfficeMail);
                    writer.WriteLine(userLoginInfoList[i].User.Contact.Email.PersonalMail);
                    writer.WriteLine(userLoginInfoList[i].User.Contact.Address.Street);
                    writer.WriteLine(userLoginInfoList[i].User.Contact.Address.City);
                    writer.WriteLine(userLoginInfoList[i].User.Contact.Address.Zip);
                    writer.WriteLine(userLoginInfoList[i].User.Contact.Address.Country.ToString());
                    writer.WriteLine(userLoginInfoList[i].User.UserType.ToString());
                }
            }
            catch
            {
                ok = false;
            }
            finally
            {
                if (writer != null)
                {
                    writer.Close();
                }
            }
            return ok;
        }
        /// <summary>
        /// Method to read a file and import user data
        /// </summary>
        /// <param name="routeList">List of data referenced</param>
        /// <returns></returns>
        public bool ReadRoutesData(List<Route> routeList)
        {
            bool ok = true;
            StreamReader reader = null;
            try
            {
                if (routeList != null)
                {
                    routeList.Clear();
                }
                else
                {
                    routeList = new();
                }
                if (!File.Exists(fileNameRoutesData))
                {
                    return true;
                }
                reader = new StreamReader(fileNameRoutesData);
                string versionTest = reader.ReadLine();
                double version = int.Parse(reader.ReadLine());
                string author = reader.ReadLine();
                if ((versionTest == fileVersionToken) && (version == fileVersionNr) && (author == fileAuthor))
                {
                    int count = int.Parse(reader.ReadLine());
                    for (int i = 0; i < count; i++)
                    {
                        Route route = new();
                        route.from = reader.ReadLine();
                        route.to = reader.ReadLine();
                        route.price = double.Parse(reader.ReadLine());
                        route.transportationType = (TransportationTypes)Enum.Parse(typeof(TransportationTypes), reader.ReadLine());
                        route.minutes = int.Parse(reader.ReadLine());
                        routeList.Add(route);
                    }
                }
                else
                {
                    ok = false;
                }
            }
            catch
            {
                ok = false;
            }
            finally
            {
                if (reader != null)
                {
                    reader.Close();
                }
            }
            return ok;
        }
        /// <summary>
        /// Method to save all route data to file
        /// </summary>
        /// <param name="routeList">route data to save</param>
        /// <returns></returns>
        public bool WriteRoutesDataToFile(List<Route> routeList)
        {
            bool ok = true;
            StreamWriter writer = null;
            try
            {
                writer = new StreamWriter(fileNameRoutesData);
                writer.WriteLine(fileVersionToken);
                writer.WriteLine(fileVersionNr);
                writer.WriteLine(fileAuthor);
                writer.WriteLine(routeList.Count);
                for (int i = 0; i < routeList.Count; i++)
                {
                    writer.WriteLine(routeList[i].from);
                    writer.WriteLine(routeList[i].to);
                    writer.WriteLine(routeList[i].price.ToString());
                    writer.WriteLine(routeList[i].transportationType.ToString());
                    writer.WriteLine(routeList[i].minutes.ToString());
                }
            }
            catch
            {
                ok = false;
            }
            finally
            {
                if (writer != null)
                {
                    writer.Close();
                }
            }
            return ok;
        }
        /// <summary>
        /// Method to save all route data to file
        /// </summary>
        /// <param name="solution">solution bought</param>
        /// <returns></returns>
        public bool WriteReceiptToFile(Solution solution)
        {
            bool ok = true;
            StreamWriter writer = null;
            try
            {
                DateTime dt = DateTime.Now;
                writer = new StreamWriter("./Tickets/" + dt.Year.ToString() + "_" + dt.Month.ToString() + "_" + dt.Day.ToString() + "__" + dt.Hour.ToString() + "_" + dt.Minute.ToString() + "_" + dt.Second.ToString() + ".txt");
                writer.WriteLine(fileVersionToken);
                writer.WriteLine(fileVersionNr);
                writer.WriteLine(fileAuthor);
                writer.WriteLine("From " + solution.From);
                writer.WriteLine("Change " + (solution.Rm.GetRouteList().Count == 1
                                 ?
                                    "--"
                                 :
                                    (solution.Rm.GetRouteList().Count == 2
                                     ?
                                        solution.Rm.GetRouteList()[0].to
                                     :  
                                       (solution.Rm.GetRouteList()[0].to
                                       + ", " +
                                       solution.Rm.GetRouteList()[1].to))));
                writer.WriteLine("To " + solution.To);
                writer.WriteLine("Price per one " + solution.Price.ToString() + "€");
                writer.WriteLine("Total price " + solution.TotalPrice.ToString() + "€");
                writer.WriteLine("Minutes " + solution.TotalMinutes.ToString());
            }
            catch
            {
                ok = false;
            }
            finally
            {
                if (writer != null)
                {
                    writer.Close();
                }
            }
            return ok;
        }
    }
}
