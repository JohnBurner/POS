using POS.Data;
using POS.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            var customerRepo = new CustomerRepository();

            //var customer = new Customer
            //{
            //    Name = "Yin James",
            //    Mobile = "0200262423",
            //    Address = "P. O. Box 2253, Accra"
            //};

            //customerRepo.AddCustomer(customer);

            var customers = customerRepo.GetCustomers();

            foreach (var customer in customers)
            {
                Console.WriteLine("Name: {0}", customer.Name);
            }

            Console.ReadKey();
        }
    }
}
