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
    public class OrderController : Controller
    {
        OrderManager ordermanager = new OrderManager(new EFOrder());
        public IActionResult Index()
        {
            var values = ordermanager.TGetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddOrder()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddOrder(Order order)
        {
            ordermanager.TAdd(order);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteCategory(int id)
        {
            var values = ordermanager.TGetBYID(id);
            ordermanager.TDElete(values);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult EditOrder(int id)
        {
            ViewBag.v1 = "Order List ";
            ViewBag.v2 = "Order";
            ViewBag.v3 = "Order List";
            var values = ordermanager.TGetBYID(id);
            return View(values);

        }
        public IActionResult EditOrder(Order order)
        {
            ordermanager.TUpdate(order);
            return RedirectToAction("Index");
        }
    }
}
