using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Common
{
   public abstract class BaseEntity
    {
        //all tables will  use BaseEntity.
        // public int Id { get; set; }

        public bool Status { get; set; }
        public DateTime CreationDate { get; set; } = DateTime.Now;
    }
}
