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
    public class JobTitleService : IJobTitleService
    {
        public JobTitleService(AppDbContext DbContext)
        {
            this._DbContext = DbContext;
        }

        public AppDbContext _DbContext { get; }
        public JobTitle AddJobTitle(JobTitle jobTitle)
        {
            try
            {
                jobTitle.CreatedAt = DateTime.Now;
                jobTitle.UpdatedAt = DateTime.Now;
                this._DbContext.jobTitles.Add(jobTitle);
                this._DbContext.SaveChanges();
                return jobTitle;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public bool DeleteJobTitle(string id)
        {
            try
            {
                var jobTitle = this._DbContext.jobTitles.Find(id);
                this._DbContext.jobTitles.Remove(jobTitle);
                this._DbContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public List<JobTitle> GetAll()
        {
            return this._DbContext.jobTitles.ToList();
        }

        public JobTitle GetById(string id)
        {
            return this._DbContext.jobTitles.Find(id);
        }

        public JobTitle UpdateJobTitle(JobTitle jobTitle)
        {
            try
            {
                var newJobTitle = this._DbContext.jobTitles.Find(jobTitle.JobTitleId);
                if (newJobTitle != null)
                {
                    newJobTitle.JobTitleName = jobTitle.JobTitleName;
                    newJobTitle.UpdatedAt = DateTime.Now;
                    this._DbContext.SaveChanges();
                    return newJobTitle;
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
