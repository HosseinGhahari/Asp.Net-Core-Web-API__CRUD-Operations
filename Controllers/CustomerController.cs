using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Web_Api___Repository_Pattern.Model;
using Web_Api___Repository_Pattern.Repository.Interface;

namespace Web_Api___Repository_Pattern.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private ICustomer _db;
        public CustomerController(ICustomer db)
        {
            _db = db;
        }


        [HttpGet]
        [Route("GetAllCustomers")]
        public IActionResult Index()
        {
            var Result = _db.GetAll();
            if (Result == null)
            {
                return NotFound();
            }
            return Ok(Result);
        }

        [HttpGet]
        [Route("GetCustomerById")]
        public IActionResult GetById(int id)
        {
            Customer Result  = _db.GetById(id);
            if (Result == null)
            {
                return NotFound();
            }
            return Ok(Result);
        }

        [HttpPost]
        [Route("InsertCustomer")]
        public IActionResult InsertCustomer([FromQuery]Customer Customer)
        {
            if(Customer != null)
            {
                _db.InsertCustomer(Customer);
                _db.Save();
            }
            return Ok();
        }

        [HttpPut]
        [Route("UpdateCustomer")]
        public IActionResult UpdateCustomer(Customer Customer)
        {
            if(Customer != null)
            {
                _db.UpdateCustomer(Customer);
                _db.Save();
            }
            return Ok();
        }

        [HttpDelete]
        [Route("DeleteCustomer")]
        public IActionResult DeleteCustomer(int id)
        {
            Customer Result = _db.GetById(id);
            if (Result == null)
            {
                return BadRequest("Id does not exist");
            }
            if (id != null)
            {
                _db.DeleteCustomer(id);
                _db.Save();
            }

            return Ok();
        }
    }
}
