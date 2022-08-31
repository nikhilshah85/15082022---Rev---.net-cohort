using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace shoppingAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {

        static List<string> cList = new List<string>()
        {
            "Nikhil","Allan","Kay","Juniper"
        };

        [HttpGet]
        [Route("customers")]
        public IActionResult GetAllCustomers()
        {
            return Ok(cList);
        }

        [HttpGet]
        [Route("customers/{idx}")]
        public IActionResult GetCustomerByIndex(int idx)
        {
            return Ok(cList[idx]);
        }

        [HttpGet]
        [Route("customers/total")]
        public IActionResult GetTotalCustomers()
        {
            return Ok(cList.Count);
        }

        [HttpPost]
        [Route("customers/add/{cname}")]
        public IActionResult AddCustomer(string cname)
        {
            cList.Add(cname);
            return Created("", cList);
        }


        [HttpDelete]
        [Route("customers/delete/{position}")]
        public IActionResult DeleteCustomer(int position)
        {
            cList.RemoveAt(position);
            return Accepted("Customer Deleted");
        }

        [HttpPut]
        [Route("customers/update/{position}/{newvalue}")]
        public IActionResult UpdateCustomer(int position, string newvalue)
        {
            cList[position] = newvalue;
            return Accepted("Customer name changed successfully");
        }


    }
}
