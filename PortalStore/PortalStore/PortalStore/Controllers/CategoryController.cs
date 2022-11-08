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
    public class CategoryController : Controller
    {
        CategoryManager categorymanager = new CategoryManager(new EFCategory());
        public IActionResult Index()
        {
            var values = categorymanager.TGetList(); 
            return View(values);
        }
        [HttpGet]
        public IActionResult AddCategory()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddCategory(Category category)
        {
            categorymanager.TAdd(category);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteCategory(int id)
        {
            var values = categorymanager.TGetBYID(id);
            categorymanager.TDElete(values);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult EditCategory(int id)
        {
            ViewBag.v1 = "Category List ";
            ViewBag.v2 = "Category";
            ViewBag.v3 = "Category List";
            var values = categorymanager.TGetBYID(id);
            return View(values);

        }
        public IActionResult EditCategory(Category category)
        {
            categorymanager.TUpdate(category);
            return RedirectToAction("Index");
        }
    }
}
