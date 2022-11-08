using BusinessLayer.Concrete;
using DataAccessLayer.Entity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortalStore.ViewComponents.OrderItem
{
    public class OrderItemList : ViewComponent

    {
        public IViewComponentResult Invoke()
        {
            OrderItemManager orderitemmanager = new OrderItemManager(new EFOrderItem());
            var values = orderitemmanager.TGetList();
            return View(values);
        }
    }
}
