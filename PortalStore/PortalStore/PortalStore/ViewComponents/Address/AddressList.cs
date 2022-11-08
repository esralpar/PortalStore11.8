using BusinessLayer.Concrete;
using DataAccessLayer.Abscract;
using DataAccessLayer.Entity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortalStore.ViewComponents.Address
{
    public class AddressList:ViewComponent
    {
        public IViewComponentResult Invoke()
        {

            AddressManager addressManager = new AddressManager (new EFAddress());
            var values = addressManager.TGetList();
            return View(values);
        }
    }
}
