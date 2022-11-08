using Api_PortalStore.DAL.APIContext;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api_PortalStore.Controllers
{
    [Route("api/[controller]")]
    //  [Route("api/[controller]/[action]")]
    [ApiController]
    public class CustomerApiController : ControllerBase
    {
        mernis.KPSPublicSoapClient ServiceCustomer = new mernis.KPSPublicSoapClient(mernis.KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
        [HttpGet]
        public IActionResult CustomerList()
        {
            using var c = new Context();
            return Ok(c.Customers.ToList());
        }
        [HttpGet("{id}")]
        public IActionResult CustomerGet(int id)
        {
            using var c = new Context();
            var value = c.Customers.Find(id);
            if (value == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(value);
            }

        }

        [HttpPost]
        public async Task<IActionResult> CustomerAdd(Customer p)
        {

            using var c = new Context();
            var response = await ServiceCustomer.TCKimlikNoDogrulaAsync(p.TCID, p.FirstName, p.LastName, p.Birthdate.Year);
            if (response.Body.TCKimlikNoDogrulaResult)
            {
                c.Customers.Add(p);
                var result = c.SaveChanges();
                if (result > 0)
                {
                    return Created("", p);
                }
                else
                {
                    return Conflict();
                }
            }
            else
            {
                return Conflict("The data you entered could not be verified.");
            }

        }
        //[HttpPost]
        //public IActionResult CustomerAddWithName(Customer p, string name)
        //{

        //    using var c = new Context();
        //    c.Customers.Add(p);
        //    var result = c.SaveChanges();
        //    if (result > 0)
        //    {
        //        return Created("", p);
        //    }
        //    else
        //    {
        //        return Conflict();
        //    }

        //}
        [HttpDelete]
        public IActionResult CustomerDelete(int id)
        {
            using var c = new Context();
            var value = c.Customers.FirstOrDefault(s => s.Id == id);
            if (value == null)
            {
                return NotFound();
            }
            else
            {
                c.Remove(value);
                c.SaveChanges();
                return NoContent();
            }
        }
        [HttpPut]
        public IActionResult CustomerUpdate(Customer param)
        {

            using var c = new Context();
            var value = c.Customers.FirstOrDefault(s => s.Id == param.Id);
            if (value == null)
            {
                return NotFound();
            }
            else
            {
                value.FirstName = param.FirstName;
                value.LastName = param.LastName;
                value.Email = param.Email;
                value.TCID = param.TCID;
                value.Birthdate = param.Birthdate;
                value.Gsm = param.Gsm;
                value.Status = param.Status;
                value.CreationDate = param.CreationDate;
                c.Update(value);
                c.SaveChanges();
                return NoContent();
            }

        }
    }
}
