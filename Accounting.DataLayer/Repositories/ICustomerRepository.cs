using Accounting.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.DataLayer
{
    public interface ICustomerRepository
    {
        List<Customers> GetAllCustomers();
        IEnumerable<Customers> GetCustomersByFilter(string parameter);
        List<ListCustomerViewModel> GetNameCustomers(string filter = null);

        Customers GetCustomerbyId(int customerId);
        bool InsertCustomer(Customers customer);
        bool UpdateCustomer(Customers customer);
        bool DeleteCustomer(Customers customer);
        bool DeleteCustomer(int customerId);

        string GetCustomerNameById(int customerId);
        string GetCustomerImageById(int customerId);

    }
}
