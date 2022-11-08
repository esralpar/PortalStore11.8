using EntityLayer.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
   public class Address
    {
        [Key]
        public int Id { get; set; }
        public string AddressLine { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Discrict { get; set; }
        public int ZipCode { get; set; }
        public int CustomerId { get; set; }
        public bool Status { get; set; }
        public DateTime CreationDate { get; set; } = DateTime.Now;
    }
}
