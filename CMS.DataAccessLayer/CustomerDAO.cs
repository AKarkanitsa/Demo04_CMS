using System;
using System.Collections.Generic;
using CMS.BusinessLayer;

namespace CMS.DataAccessLayer
{
    public class CustomerDAO
    {
        public string path = "CMS_DB";
        //Connect to Database
        public void Connect() { }

        //Get Customer with some ID from Database
        public Customer GetCustomer(int ID)
        {
            return new Customer();
        }

        //Get all Customers
        public List<Customer> GetCustomers()
        {
            return new List<Customer>();
        }

        public Customer GetCustomerByName(string customerName)
        {
            return new Customer();
        }

    }
}
