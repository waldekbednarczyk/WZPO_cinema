using System;
using System.Collections.Generic;
using System.Text;
using WZPO.DataAccess.Models;

namespace WZPO.IServices
{
    public interface IUserService
    {
        User GetUserById(int id);
        IEnumerable<User> GetAllUsers();
        int CreateUser(User user);
        void EditUser(User user);
        void DeleteUser(User user);
    }
}
