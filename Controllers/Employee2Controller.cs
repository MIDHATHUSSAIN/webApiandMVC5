using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using webAPIandMVC.Models;

namespace webAPIandMVC.Controllers
{
    public class Employee2Controller : ApiController
    {
        // GET: Employee2
        private readonly EmployeeRepository _repository = new EmployeeRepository();

        //[HttpGet]
    
        //public IHttpActionResult Get()
        //{
        //    return Ok(_repository.GetAllEmployees());
        //}

        [HttpPost]

        public IHttpActionResult Post([FromBody] data employee)
        {
            if (_repository.AddEmployee(employee))
                return Ok(new { success = true, message = "Employee added successfully!" });

            return BadRequest("Failed to add employee.");
        }

        //[HttpPut]
   
        //public IHttpActionResult Put(int id, [FromBody] data employee)
        //{
        //    if (_repository.UpdateEmployee(id, employee))
        //        return Ok(new { success = true, message = "Employee updated successfully!" });

        //    return BadRequest("Failed to update employee.");
        //}

        //[HttpDelete]

        //public IHttpActionResult Delete(int id)
        //{
        //    if (_repository.DeleteEmployee(id))
        //        return Ok(new { success = true, message = "Employee deleted successfully!" });

        //    return BadRequest("Failed to delete employee.");
        //}
    }
}
