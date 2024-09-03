using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.DataLayer.Context
{
    public class UnitOfWork : IDisposable
    {
        Accounting_DBEntities db = new Accounting_DBEntities();
        private ICustomerRepository _customerRepository;

        public ICustomerRepository CustomerRepository
        {
            get
            {
                if (_customerRepository == null)
                {
                    _customerRepository = new CustomerRepository(db);
                }
                return _customerRepository;
            }
        }

        private EntityGenericRepository<Accounting> _accountingRepository;

        public EntityGenericRepository<Accounting> AccountingRepository
        {
            get
            {
                if (_accountingRepository == null)
                {
                    _accountingRepository = new EntityGenericRepository<Accounting>(db);
                }
                return _accountingRepository;
            }
        }

        public void Save()
        {
            db.SaveChanges();
        }
        public void Dispose()
        {
            db.Dispose();
        }
    }
}
