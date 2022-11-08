using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    //connection and sql table
    public class Context: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=YAZILIM-N02; database=PortalStoreDB; integrated security=true;");
        }
        public DbSet <Address> Adresses { get; set; }
        public DbSet <Category> Categories { get; set; }
        public DbSet <Customer> Customers { get; set; }
        public DbSet <Order> Orders { get; set; }
        public DbSet <OrderItem> OrderItems { get; set; }
        public DbSet <SKU> SKUs { get; set; }
    }
}
