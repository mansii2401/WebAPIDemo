using Microsoft.AspNetCore.Mvc;
using WebAPIDemo.Data;
using WebAPIDemo.Models;
using static System.Reflection.Metadata.BlobBuilder;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAPIDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        // GET: api/<EmployeeController>
        [HttpGet]
        public ActionResult<List<Employee>> GetEmployee()
        {
            return (EmployeeData.employees);
        }

        // GET api/<EmployeeController>/5
        [HttpGet("{id}")]
        public ActionResult GetEmployeeDetails(int id)
        {
            var employee = EmployeeData.employees.Find(e => e.Id == id);
            if (employee == null)
            {
                return NotFound();
            }
            return Ok(employee);
        }

        //    //// POST api/<EmployeeController>
        //    //[HttpPost]
        //    //public void Post([FromBody] string value)
        //    //{
        //    //}

        //    //// PUT api/<EmployeeController>/5
        //    //[HttpPut("{id}")]
        //    //public void Put(int id, [FromBody] string value)
        //    //{
        //    //}

        //    //// DELETE api/<EmployeeController>/5
        //    //[HttpDelete("{id}")]
        //    //public void Delete(int id)
        //    //{
        //    //}
        }
    }
