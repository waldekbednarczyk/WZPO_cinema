using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WZPO.DataAccess.Models;
using WZPO.IServices;

namespace WZPO.Controllers
{
    public class SeanceController : Controller
    {
        private readonly ISeanceService _service;
        public SeanceController(ISeanceService service)
        {
            _service = service;
        }
        public ActionResult CreateSeance(Seance seance)
        {
            _service.CreateSeance(seance);
            return Ok();
        }
        public ActionResult DeleteSeance(Seance seance)
        {
            _service.DeleteSeance(seance);
            return Ok();
        }
        public ActionResult EditSeance(Seance seance)
        {
            _service.EditSeance(seance);
            return Ok();
        }
        public ActionResult<IEnumerable<Seance>> GetAllSeancess()
        {
            var seances = _service.GetAllSeancess();

            return Ok(seances);
        }
        [HttpGet("seance/{id})")]
        public ActionResult GetSeanceById(int id)
        {
            var seance = _service.GetSeanceById(id);

            return Ok(seance);
        }
    }
}
