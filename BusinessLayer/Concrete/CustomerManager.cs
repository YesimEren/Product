using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CustomerManager : ICustomerService
    {
        ICustomer _customer;
        public CustomerManager(ICustomer customerdal)
        {
            _customer = customerdal;
        }
        public List<Customer> GetList()
        {
            return _customer.GetList();
        }

        public void TDelete(Customer t)
        {
            _customer.Delete(t);
        }

        public Customer TGetById(int id)
        {
            return _customer.GetById(id);
        }

        public void TUpdate(Customer t)
        {
            _customer.Update(t);
        }

        public void Tİnsert(Customer t)
        {
            _customer.Insert(t);
        }
    }
}
