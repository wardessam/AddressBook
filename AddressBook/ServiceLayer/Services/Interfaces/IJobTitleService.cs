using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainLayer.Models;
namespace ServiceLayer.Services.Interfaces
{
    public interface IJobTitleService
    {
        List<JobTitle> GetAll();
        JobTitle GetById(string id);
        JobTitle AddJobTitle(JobTitle jobTitle);
        JobTitle UpdateJobTitle(JobTitle jobTitle);
        bool DeleteJobTitle(string id);
    }
}
