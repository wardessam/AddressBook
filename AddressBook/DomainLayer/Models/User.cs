using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace DomainLayer.Models
{
    public class User : IdentityUser
    {
        public string FullName { get; set; }
        public string JobTitleId   { get; set; }
        public string DepartmentId { get; set; }
        public string? MobileNumber { get; set; }
        public DateTime BirthDate { get; set; }
        public string? Address { get; set; }
        [NotMapped]
        public string Password { get; set; }
        public string? PhotoName { get; set; }
        public int Age { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

    }
}
