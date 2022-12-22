using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    public class CustomerManager
    {
        private List<Customer> customerList;
        private List<int> Ids;
        private int counter = 0;
        /// <summary>
        /// Basic constructor
        /// </summary>
        public CustomerManager()
        {
            customerList = new List<Customer>();
            Ids = new List<int>();
        }
        /// <summary>
        /// Method to retrieve customer list
        /// </summary>
        public List<Customer> GetCustomerList()
        {
            return customerList;
        }
        /// <summary>
        /// Method to get the customer at i index from list
        /// </summary>
        /// <param name="i">index</param>
        public Customer GetCustomer(int i)
        {
            return customerList[i];
        }
        /// <summary>
        /// Method to retrieve the id at i index from the list
        /// </summary>
        /// <param name="i">index</param>
        public int GetId(int i)
        {
            return Ids[i];
        }
        /// <summary>
        /// Method to add a customer to the list
        /// </summary>
        /// <param name="contact">Contact to be added</param>
        public void AddCustomer(Contact contact)
        {
            customerList.Add(new Customer(contact));
            Ids.Add(counter);
            counter++;
        }
        /// <summary>
        /// Method to remove a customer from the list
        /// </summary>
        /// <param name="contactIndex">Contact index to be removed</param>
        public void RemoveCustomer(int contactIndex)
        {
            customerList.RemoveAt(contactIndex);
        }
        /// <summary>
        /// Method to swap a customer to the list
        /// </summary>
        /// <param name="c">Contact to be added</param>
        /// <param name="index">Index to be swapped</param>
        public void ChangeCustomer(Contact c, int index)
        {
            customerList[index].contact = c;
        }
    }
}
