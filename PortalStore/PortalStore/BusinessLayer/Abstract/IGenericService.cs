using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
  public  interface IGenericService<T>
    {
        void TAdd(T t);
        void TDElete(T t);
        void TUpdate(T t);
        List<T> TGetList();
        T TGetBYID(int id);
    }
}
