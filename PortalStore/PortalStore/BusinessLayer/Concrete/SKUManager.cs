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
    public class SKUManager : ISKUService
    {
        ISKUDal _sKUDal;

        public SKUManager(ISKUDal sKUDal)
        {
            _sKUDal = sKUDal;
        }

        public void TAdd(SKU t)
        {
            _sKUDal.Insert(t);
        }

        public void TDElete(SKU t)
        {
            _sKUDal.Delete(t);
        }

        public SKU TGetBYID(int id)
        {
            return _sKUDal.GetByID(id);
        }

        public List<SKU> TGetList()
        {
            return _sKUDal.GetList();
        }

        public void TUpdate(SKU t)
        {
            _sKUDal.Update(t);
        }
    }
}
