using BusinessLayer.Concrete;
using DataAccessLayer.Entity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortalStore.ViewComponents.Order
{
    public class OrderList:ViewComponent
    {
        public IViewComponentResult Invoke()
        {

            OrderManager ordermanager = new OrderManager(new EFOrder());
            var values = ordermanager.TGetList();
            return View(values);
        }
      
    }
}
