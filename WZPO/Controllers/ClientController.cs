using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WZPO.DataAccess.Models;
using WZPO.IServices;

namespace WZPO.Controllers
{
    public class ClientController : Controller
    {
        private readonly IClientService _service;
        public ClientController(IClientService service)
        {
            _service = service;
        }
        [HttpGet("client/{id})")]
        public ActionResult GetClientById(int id)
        {
            var room = _service.GetClientById(id);

            return Ok(room);
        }
        public ActionResult<IEnumerable<Client>> GetAllClients()
        {
            var clients = _service.GetAllClients();

            return Ok(clients);
        }
        public ActionResult EditClient(Client client)
        {
            _service.EditClient(client);
            return Ok();
        }
        public ActionResult DeleteClient(Client client)
        {
            _service.DeleteClient(client);
            return Ok();
        }
        public ActionResult CreateClient(Client client)
        {
            _service.CreateClient(client);
            return Ok();
        }
    }
}
