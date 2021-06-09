using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WZPO.DataAccess.Models;
using WZPO.IServices;

namespace WZPO.Controllers
{
    public class ReservationController : Controller
    {
        private readonly IReservationService _service;
        public ReservationController(IReservationService service)
        {
            _service = service;
        }
        public ActionResult<IEnumerable<Reservation>> GetAllReservations()
        {
            var reservations = _service.GetAllReservations();

            return Ok(reservations);
        }
        [HttpGet("reservation/{id})")]
        public ActionResult GetReservationById(int id)
        {
            var reservation = _service.GetReservationById(id);

            return Ok(reservation);
        }
        [HttpPut("reservation")]
        public ActionResult MakeReservation([FromBody] Reservation reservation)
        {
            _service.MakeReservation(reservation);

            return Ok();
        }
        public ActionResult CancelReservation(Reservation reservation)
        {
            _service.CancelReservation(reservation);
            return Ok();
        }
    }
}
