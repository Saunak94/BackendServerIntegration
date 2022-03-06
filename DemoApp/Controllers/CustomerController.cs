using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DemoApp.Contract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DemoApp.Controllers
{
    [Route("api/[controller]/[action]")]
   
    public class CustomerController : Controller
    {

        #region Private Variables
        private ICustomerBusiness _cutomerBusinessBusiness;
        #endregion

        #region Constructor
        public CustomerController(ICustomerBusiness customerBusiness)
        {
            _cutomerBusinessBusiness = customerBusiness;
           
        }
        #endregion


        // Method returns all customer Information
        [HttpGet]     
        public async Task<IActionResult> GetAllCustomerInfo()
        {
            return Ok("Hello...");
          /*  var customerList = await _cutomerBusinessBusiness.GetAllCustomerList();
            if (customerList != null)
            {
                return Ok(customerList);
            }
            else
            {
                return BadRequest();
            }
          */
        }
    }
}
