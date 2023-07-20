using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainLayer.Models;
using ServiceLayer.Services.Interfaces;
using RepositoryLayer;
namespace ServiceLayer.Services.Classes
{
    public class DepartmentService : IDepartmentService
    {
        public DepartmentService(AppDbContext DbContext)
        {
            this._DbContext = DbContext;
        }

        public AppDbContext _DbContext { get; }
        public Department AddDepartment(Department department)
        {
            try
            {
                department.CreatedAt = DateTime.Now;
                department.UpdatedAt = DateTime.Now;
                this._DbContext.departments.Add(department);
                this._DbContext.SaveChanges();
                return department;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public bool DeleteDepartment(string id)
        {
            try
            {
                var department = this._DbContext.departments.Find(id);
                this._DbContext.departments.Remove(department);
                this._DbContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public List<Department> GetAll()
        {
            return this._DbContext.departments.ToList();
        }

        public Department GetById(string id)
        {
            return this._DbContext.departments.Find(id);
        }

        public Department UpdateDepartment(Department department)
        {
            try
            {
                var newDepartment = this._DbContext.departments.Find(department.DepartmentId);
                if (newDepartment != null)
                {
                    newDepartment.DepartmentName = department.DepartmentName;
                    newDepartment.UpdatedAt = DateTime.Now;
                    this._DbContext.SaveChanges();
                    return newDepartment;
                }
                else
                {
                    return null;
                }
                this._DbContext.SaveChanges();

            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
