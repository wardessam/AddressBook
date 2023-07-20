using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Models
{
    public class AuthModel
    {
        public User User { get; set; }
        public string Message { get; set; }
        public string Token { get; set; }
        public DateTime ExpiresOn { get; set; }
    }
}
