using BusinessLayer.Concrete;
using DataAccessLayer.Entity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortalStore.ViewComponents.Category
{
    public class CetegoryList: ViewComponent

    {
        public IViewComponentResult Invoke()
        {

            CategoryManager categoryManager = new CategoryManager(new EFCategory());
            var values = categoryManager.TGetList();
            return View(values);
        }
    }
}
