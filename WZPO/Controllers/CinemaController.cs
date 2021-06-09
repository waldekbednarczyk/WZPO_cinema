using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WZPO.DataAccess.Models;
using WZPO.Services;

namespace WZPO.Controllers
{
    public class CinemaController : Controller
    {
        private readonly ICinemaService _service;
        public CinemaController(ICinemaService service)
        {
            _service = service;
        }

        public ActionResult AddCinemaRoom(CinemaRoom cinemaRoom)
        {
            _service.AddCinemaRoom(cinemaRoom);
            return Ok();
        }

        public ActionResult DeleteCinemaRoom(CinemaRoom cinemaRoom)
        {
            _service.DeleteCinemaRoom(cinemaRoom);
            return Ok();
        }
        public ActionResult EditCinemaRoom(CinemaRoom cinemaRoom)
        {
            _service.EditCinemaRoom(cinemaRoom);
            return Ok();
        }
        public ActionResult<IEnumerable<CinemaRoom>> GetAllCinemaRooms()
        {
            var cinemaRooms = _service.GetAllCinemaRooms();

            return Ok(cinemaRooms);
        }

        [HttpGet("cinemaroom/{id})")]
        public ActionResult GetCinemaRoomById(int id)
        {
            var room = _service.GetCinemaRoomById(id);

            return Ok(room);
        }
    }
}
