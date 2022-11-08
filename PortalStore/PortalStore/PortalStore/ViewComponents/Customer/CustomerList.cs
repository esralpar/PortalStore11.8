using BusinessLayer.Concrete;
using DataAccessLayer.Entity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortalStore.ViewComponents.Customer
{
    public class CustomerList: ViewComponent
    {
        public IViewComponentResult Invoke()
        {

            CustomerManager customermanager = new CustomerManager(new EFCustomer());
            var values = customermanager.TGetList();
            return View(values);
        }
    }
}
