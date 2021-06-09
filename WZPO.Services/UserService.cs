using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WZPO.DataAccess.Context;
using WZPO.DataAccess.Models;
using WZPO.IServices;

namespace WZPO.Services
{
    public class UserService : IUserService
    {
        private readonly CinemaDbContext _dbContext;
        public UserService(CinemaDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public int CreateUser(User user)
        {
            _dbContext.Users.Add(user);
            _dbContext.SaveChanges();
            return user.Id;
        }
        public void DeleteUser(User user)
        {
            _dbContext.Users.Remove(user);
            _dbContext.SaveChanges();
        }

        public void EditUser(User user)
        {
            var _user = _dbContext.Users.Where(u => u.Id == user.Id).FirstOrDefault();
            if (_user == null) return;

            _user.Email = user.Email;
            _user.Name = user.Name;
            _user.Surname = user.Surname;
            _dbContext.SaveChanges();
        }
        public User GetUserById(int id)
        {
            return _dbContext.Users.Where(r => r.Id == id).FirstOrDefault();
        }
        public IEnumerable<User> GetAllUsers()
        {
            return _dbContext.Users;
        }
    }
}
