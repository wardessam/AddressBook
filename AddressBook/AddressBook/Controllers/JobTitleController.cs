using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServiceLayer.Services.Interfaces;
using DomainLayer.Models;
namespace WebAPILayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JobTitleController : ControllerBase
    {
        private IJobTitleService _JobTitle { get; }
        public JobTitleController(IJobTitleService jobTitle)
        {
            this._JobTitle = jobTitle;
        }

        [HttpGet]
        [Route("GetAllJobTitles")]
        public IActionResult GetAll()
        {
            return Ok(this._JobTitle.GetAll());
        }
        [HttpGet("GetJobTitle")]
        public IActionResult GetById(string Id)
        {
            return Ok(this._JobTitle.GetById(Id));
        }
        [HttpPost("AddJobTitle")]
        public IActionResult AddJobTitle(JobTitle jobTitle)
        {
            return Ok(this._JobTitle.AddJobTitle(jobTitle));
        }
        [HttpPut("UpdateJobTitle")]
        public IActionResult UpdateJobTitle(JobTitle jobTitle)
        {
            return Ok(this._JobTitle.UpdateJobTitle(jobTitle));
        }
        [HttpDelete("DeleteJobTitle/{Id}")]
        public IActionResult DeleteJobTitle(string Id)
        {
            return Ok(this._JobTitle.DeleteJobTitle(Id));
        }
    }
}
