using API.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly EmployeeRepo employeeRepo;

        public EmployeeController(EmployeeRepo employeeRepo)
        {
            this.employeeRepo = employeeRepo;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(employeeRepo.GetAll());
        }
        [HttpGet("{id:int}")]
        public IActionResult GetById(int id)
        {
            return Ok(employeeRepo.GetById(id));
        }
    }
}
