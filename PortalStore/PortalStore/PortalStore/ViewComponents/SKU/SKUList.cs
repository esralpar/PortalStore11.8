using BusinessLayer.Concrete;
using DataAccessLayer.Entity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortalStore.ViewComponents.SKU
{
    public class SKUList: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            SKUManager skumanager = new SKUManager(new EFSKU());
            var values = skumanager.TGetList();
            return View(values);
        }
    }
}
