using System;
using CMS.BusinessLayer;
using CMS.Common;
using System.Collections.Generic;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerRepository repository = new CustomerRepository();
            Customer customer = repository.Retrieve(1);

            Console.WriteLine("==============================================");
            Console.WriteLine("Customer from Repository with ID1: " + customer);

            Console.WriteLine("==============================================");
            
            
            Console.WriteLine("Log File:");
            List<ILoggable> items = new List<ILoggable>();
            items.Add(customer);
            LoggingService.WriteToFile(items);
            Console.WriteLine("==============================================");
        }
    }
}
