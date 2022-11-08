using BusinessLayer.Abstract;
using DataAccessLayer.Abscract;
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
        ICustomerDal _costumerDal;

        public CustomerManager(ICustomerDal costumerDal)
        {
            _costumerDal = costumerDal;
        }

        public void TAdd(Customer t)
        {
            _costumerDal.Insert(t);
        }

        public void TDElete(Customer t)
        {
            _costumerDal.Delete(t);
        }

        public Customer TGetBYID(int id)
        {
            return _costumerDal.GetByID(id);
        }

        public List<Customer> TGetList()
        {
            return _costumerDal.GetList();
        }

        public void TUpdate(Customer t)
        {
            _costumerDal.Update(t);
        }
    }
}
