using EntityLayer.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
   public class OrderItem
    {
        [Key]
        public int Id { get; set; }
        public int SkuId { get; set; }
        public int OrderID { get; set; }
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }
        public bool Status { get; set; }
        public DateTime CreationDate { get; set; } = DateTime.Now;
    }
}
