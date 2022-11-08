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
    public class SKUController : Controller
    {
        SKUManager skumanager = new SKUManager(new EFSKU());
        public IActionResult Index()
        {
            var values = skumanager.TGetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddSKU()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddSKU(SKU sku)
        {
            skumanager.TAdd(sku);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteSKU(int id)
        {
            var values = skumanager.TGetBYID(id);
            skumanager.TDElete(values);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult EditSKU(int id)
        {
            ViewBag.v1 = "SKU List ";
            ViewBag.v2 = "SKU";
            ViewBag.v3 = "SKU List";
            var values = skumanager.TGetBYID(id);
            return View(values);

        }
        public IActionResult EditSKU(SKU sku)
        {
            skumanager.TUpdate(sku);
            return RedirectToAction("Index");
        }
    }
}
