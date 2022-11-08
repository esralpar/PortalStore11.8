using BusinessLayer.Concrete;
using DataAccessLayer.Entity;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortalStore.Controllers
{
    public class OrderItemController : Controller
    {
        OrderItemManager orderitemmanager = new OrderItemManager(new EFOrderItem());
        public IActionResult Index()
        {

            var values = orderitemmanager.TGetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddOrderItem()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddOrderItem(OrderItem orderitem)
        {
            orderitemmanager.TAdd(orderitem);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteOrderItem(int id)
        {
            var values = orderitemmanager.TGetBYID(id);
            orderitemmanager.TDElete(values);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult EditOrderItem(int id)
        {
            ViewBag.v1 = "OrderItem List ";
            ViewBag.v2 = "OrderItem";
            ViewBag.v3 = "OrderItem List";
            var values = orderitemmanager.TGetBYID(id);
            return View(values);

        }
        public IActionResult EditOrderItem(OrderItem orderitem)
        {
            orderitemmanager.TUpdate(orderitem);
            return RedirectToAction("Index");
        }
    }
}
