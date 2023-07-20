using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServiceLayer.Services.Interfaces;
using DomainLayer.Models;
namespace WebAPILayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        private IDepartmentService _Department { get; }
        public DepartmentController(IDepartmentService department)
        {
            this._Department = department;
        }

        [HttpGet]
        [Route("GetAllDeps")]
        public IActionResult GetAll()
        {
            return Ok(this._Department.GetAll());
        }
        [HttpGet("GetDep")]
        public IActionResult GetById(string Id)
        {
            return Ok(this._Department.GetById(Id));
        }
        [HttpPost("AddDep")]
        public IActionResult AddDep(Department department)
        {
            return Ok(this._Department.AddDepartment(department));
        }
        [HttpPut("UpdateDep")]
        public IActionResult UpdateDep(Department department)
        {
            return Ok(this._Department.UpdateDepartment(department));
        }
        [HttpDelete("DeleteDep/{Id}")]
        public IActionResult DeleteDep(string Id)
        {
            return Ok(this._Department.DeleteDepartment(Id));
        }
    }
}
