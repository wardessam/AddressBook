using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainLayer.Models;
namespace ServiceLayer.Services.Interfaces
{
    public interface IUserService
    {
        List<User> GetAll();
        User GetById(string id);
        User AddUser(User user);
        User UpdateUser(User user);
        bool DeleteUser(string id);
    }
}
