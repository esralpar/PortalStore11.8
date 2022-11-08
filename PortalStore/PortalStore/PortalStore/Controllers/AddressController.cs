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
    public class AddressController : Controller
    {
        AddressManager addressmanager = new AddressManager(new EFAddress());
        public IActionResult Index()
        {
            var values = addressmanager.TGetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddAddress()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddAddress(Address address)
        {
            addressmanager.TAdd(address);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteAddress(int id)
        {
            var values = addressmanager.TGetBYID(id);
            addressmanager.TDElete(values);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult EditAddress(int id)
        {
            ViewBag.v1 = "Address List ";
            ViewBag.v2 = "Address";
            ViewBag.v3 = "Address List";
            var values = addressmanager.TGetBYID(id);
            return View(values);

        }
        public IActionResult EditAddress(Address address)
        { 
            addressmanager.TUpdate(address);
            return RedirectToAction("Index");
        }
    }
}
