using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using Accounting.ViewModels;

namespace Accounting.DataLayer
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly Accounting_DBEntities db;
        public CustomerRepository(Accounting_DBEntities Context)
        {
            db = Context;
        }
        public List<Customers> GetAllCustomers()
        {
            return db.Customers.ToList();
        }
        public IEnumerable<Customers> GetCustomersByFilter(string parameter)
        {
            return db.Customers
                .Where(c => c.FullName.Contains(parameter) || c.Email.Contains(parameter) || c.Mobile.Contains(parameter))
                .ToList();
        }
        public List<ListCustomerViewModel> GetNameCustomers(string filter = null)
        {
            if (filter == null)
            {
                return db.Customers.Select(c => new ListCustomerViewModel
                {
                    CustomerID = c.CustomerID,
                    FullName = c.FullName,

                }).ToList();
            }

            return db.Customers.Where(c => c.FullName.Contains(filter)).Select(c => new ListCustomerViewModel
            {
                FullName = c.FullName,

            }).ToList();
        }
        public Customers GetCustomerbyId(int customerId)
        {
            return db.Customers.Find(customerId);
        }
        public bool InsertCustomer(Customers customer)
        {
            try
            {
                db.Customers.Add(customer);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool UpdateCustomer(Customers customer)
        {
            try
            {
                var local = db.Set<Customers>()
                    .Local
                    .FirstOrDefault(f => f.CustomerID == customer.CustomerID);
                if (local != null)
                {
                    db.Entry(local).State = EntityState.Detached;
                }
                db.Entry(customer).State = EntityState.Modified;
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool DeleteCustomer(Customers customer)
        {
            try
            {
                db.Entry(customer).State = EntityState.Deleted;
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool DeleteCustomer(int customerId)
        {
            try
            {
                var customer = GetCustomerbyId(customerId);
                DeleteCustomer(customer);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public string GetCustomerNameById(int customerId)
        {
            return db.Customers.Find(customerId).FullName;
        }

        public string GetCustomerImageById(int customerId)
        {
            return db.Customers.Find(customerId).CustomerImage;
        }
    }
}
