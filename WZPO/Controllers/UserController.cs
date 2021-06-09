using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WZPO.DataAccess.Models;
using WZPO.IServices;

namespace WZPO.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserService _service;
        public UserController(IUserService service)
        {
            _service = service;
        }
        public ActionResult CreateUser(User user)
        {
            _service.CreateUser(user);
            return Ok();
        }
        public ActionResult DeleteUser(User user)
        {
            _service.DeleteUser(user);
            return Ok();
        }
        public ActionResult EditUser(User user)
        {
            _service.EditUser(user);
            return Ok();
        }
        public ActionResult<IEnumerable<User>> GetAllUsers()
        {
            var users = _service.GetAllUsers();

            return Ok(users);
        }
        [HttpGet("user/{id})")]
        public ActionResult GetUserById(int id)
        {
            var user = _service.GetUserById(id);

            return Ok(user);
        }
    }
}
