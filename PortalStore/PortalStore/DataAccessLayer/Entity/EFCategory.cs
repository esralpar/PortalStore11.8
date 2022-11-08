using DataAccessLayer.Abscract;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Entity
{
   public class EFCategory:GenericRepository<Category>,ICategoryDal
    {
    }
}
