using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainLayer.Models;
namespace ServiceLayer.Services.Interfaces
{
    public interface IDepartmentService
    {
        List<Department> GetAll();
        Department GetById(string id);
        Department AddDepartment(Department department);
        Department UpdateDepartment(Department department);
        bool DeleteDepartment(string id);
    }
}
