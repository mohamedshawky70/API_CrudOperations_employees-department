using API.Models;
using API.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        private readonly DepartmentRepo departmentRepo;

        public DepartmentController(DepartmentRepo departmentRepo)
        {
            this.departmentRepo = departmentRepo;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(departmentRepo.GetAll());
        }
        [HttpGet]
        [Route("{id:int}")]
        public IActionResult GetById(int id)
        {
            return Ok(departmentRepo.GetById(id));
        }
        [HttpGet("{name}")]
        //[Route("{name}")]
        public IActionResult GetByName(string name)
        {
            return Ok(departmentRepo.GetByName(name));
        }
        [HttpPost]
        public IActionResult Add([FromForm]Department department)
        {
            if (ModelState.IsValid == true)
            {
                departmentRepo.Add(department);
                return Ok("saved");
            }
            return BadRequest();
        }
        [HttpPut]
        public IActionResult Update(Department department)
        {
            if (ModelState.IsValid == true)
            {
                departmentRepo.Update(department);
                return Ok("Updated");
            }
            return BadRequest();
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            Department department = departmentRepo.GetById(id);
            if (department != null)
            {
                try
                {
                    departmentRepo.Delete(id);
                    return Ok(department);
                }
                catch (Exception e)
                {
                    return BadRequest(e.Message);
                }
            }
            return BadRequest();

        }

    }
}
