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
    public class UserService : IUserService
    {
        public UserService(AppDbContext DbContext)
        {
            this._DbContext = DbContext;
        }

        public AppDbContext _DbContext { get; }

        public User AddUser(User user)
        {
            try
            {
                user.CreatedAt = DateTime.Now;
                this._DbContext.users.Add(user);
                this._DbContext.SaveChanges();
                return this._DbContext.users.Find(user);
            }
            catch(Exception ex)
            {
                return null;
            }
        }

        public bool DeleteUser(string id)
        {
            try
            {
                var user = this._DbContext.users.Find(id);
                this._DbContext.users.Remove(user);
                this._DbContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public List<User> GetAll()
        {
            return this._DbContext.users.ToList();
        }

        public User GetById(string id)
        {
            return this._DbContext.users.Find(id);
        }

        public User UpdateUser(User user)
        {
            try
            {
                var oldUser = this._DbContext.users.Find(user.Id);
                if(oldUser != null){
                    oldUser.Address = user.Address;
                    oldUser.Age = user.Age;
                    oldUser.MobileNumber = user.MobileNumber;
                    oldUser.BirthDate = user.BirthDate;
                    oldUser.Email = user.Email;
                    oldUser.Password = user.Password;
                    oldUser.PhotoName = user.PhotoName;
                    oldUser.DepartmentId = user.DepartmentId;
                    oldUser.JobTitleId = user.JobTitleId;
                    oldUser.FullName = user.FullName;
                    oldUser.UpdatedAt = DateTime.Now;
                    this._DbContext.SaveChanges();
                    return oldUser;
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
