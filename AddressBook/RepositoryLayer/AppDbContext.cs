using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DomainLayer.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace RepositoryLayer
{
    public class AppDbContext : IdentityDbContext<User>
    {
        public AppDbContext(DbContextOptions con) : base(con) { }
        
        public DbSet<User> users { get; set; }
        public DbSet<Department> departments { get; set; }
        public DbSet<JobTitle> jobTitles { get; set; }
       
    }
}
