using EntityLayer.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
   public class Order
    {
        [Key]
        public int Id { get; set; }
        public int CostumerId { get; set; }
        public int AdressId { get; set; }
        public decimal TotalPrice { get; set; }
        public Category Category { get; set; }
        public Address Address { get; set; }
        public bool Status { get; set; }
        public DateTime CreationDate { get; set; } = DateTime.Now;
    }
}
