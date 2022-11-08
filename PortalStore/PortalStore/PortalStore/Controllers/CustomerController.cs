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
    public class CustomerController : Controller
    {
        CustomerManager customermanager = new CustomerManager(new EFCustomer());
        public IActionResult Index()
        {
            var values = customermanager.TGetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddCustomer()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddCustomer(Customer customer)
        {
            customermanager.TAdd(customer);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteCustomer(int id)
        {
            var values = customermanager.TGetBYID(id);
            customermanager.TDElete(values);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult EditCustomer(int id)
        {
            ViewBag.v1 = "Customer List ";
            ViewBag.v2 = "Customer";
            ViewBag.v3 = "Customer List";
            var values = customermanager.TGetBYID(id);
            return View(values);

        }
        public IActionResult EditCustomer(Customer customer)
        {
            customermanager.TUpdate(customer);
            return RedirectToAction("Index");
        }
    }
}
