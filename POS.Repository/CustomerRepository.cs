using POS.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Repository
{
    public class CustomerRepository
    {
        private POSEntities _db;

        public CustomerRepository()
        {
            _db = new POSEntities();
        }
        public void AddCustomer(Customer customer)
        {
            _db.Customers.Add(customer);
            _db.SaveChanges();
        }
        public Customer GetCustomer(int customerId)
        {
            return _db.Customers.FirstOrDefault(c => c.CustomerId == customerId);
        }
        public List<Customer> GetCustomers()
        {
            return _db.Customers.ToList();
        }
        public void RemoveCustomer(int customerId)
        {
            var customer = _db.Customers.FirstOrDefault(c => c.CustomerId == customerId);
            if (customer != null)
            {
                _db.Customers.Remove(customer);
                _db.SaveChanges();
            }

        }
        public Customer UpdateCustomer(Customer customer)
        {

            return null;
        }

    }
}
