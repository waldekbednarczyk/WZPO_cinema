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
        // GET: CinemaController
        public ActionResult Index()
        {
            return View();
        }

        // GET: CinemaController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CinemaController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CinemaController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CinemaController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CinemaController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CinemaController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CinemaController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        public ActionResult AddCinemaRoom(CinemaRoom cinemaRoom)
        {
            _service.AddCinemaRoom(cinemaRoom);
            return Ok();
        }

        public ActionResult CancelReservation(Reservation reservation)
        {
            _service.CancelReservation(reservation);
        }

        public ActionResult CreateClient(Client client)
        {
            _service.CreateClient(client);
            return Ok();
        }

        public ActionResult CreateFilm(Film film)
        {
            _service.CreateFilm(film);
            return Ok();
        }

        public ActionResult CreateSeance(Seance seance)
        {
            _service.CreateSeance(seance);
            return Ok();
        }

        public ActionResult CreateUser(User user)
        {
            _service.CreateUser(user);
            return Ok();
        }

        public ActionResult DeleteCinemaRoom(CinemaRoom cinemaRoom)
        {
            _service.DeleteCinemaRoom(cinemaRoom);
            return Ok();
        }

        public ActionResult DeleteClient(Client client)
        {
            _service.DeleteClient(client);
            return Ok();
        }

        public ActionResult DeleteFilm(Film film)
        {
            _service.DeleteFilm(film);
            return Ok();
        }

        public ActionResult DeleteSeance(Seance seance)
        {
            _service.DeleteSeance(seance);
            return Ok();
        }

        public ActionResult DeleteUser(User user)
        {
            _service.DeleteUser(user);
            return Ok();
        }

        public ActionResult EditCinemaRoom(CinemaRoom cinemaRoom)
        {
            _service.EditCinemaRoom(cinemaRoom);
        }

        public ActionResult EditClient(Client client)
        {
            _service.EditClient(client);
        }

        public ActionResult EditUser(User user)
        {
            _service.EditUser(user);
            return Ok();
        }

        public ActionResult EditFilm(Film film)
        {
            _service.EditFilm(film);
            return Ok();
        }

        public ActionResult EditSeance(Seance seance)
        {
            _service.EditSeance(seance);
            return Ok();
        }

        public ActionResult<IEnumerable<CinemaRoom>> GetAllCinemaRooms()
        {
            var cinemaRooms = _service.GetAllCinemaRooms();

            return Ok(cinemaRooms);
        }

        public ActionResult<IEnumerable<Client>> GetAllClients()
        {
            var clients = _service.GetAllClients();

            return Ok(clients);
        }

        public ActionResult<IEnumerable<Film>> GetAllFilms()
        {
            var films = _service.GetAllFilms();

            return Ok(films);
        }

        public ActionResult<IEnumerable<Reservation>> GetAllReservations()
        {
            var reservations = _service.GetAllReservations();

            return Ok(reservations);
        }

        public ActionResult<IEnumerable<Seance>> GetAllSeancess()
        {
            var seances = _service.GetAllSeancess();

            return Ok(seances);
        }

        public ActionResult<IEnumerable<User>> GetAllUsers()
        {
            var users = _service.GetAllUsers();

            return Ok(users);
        }

        [HttpGet("cinemaroom/{id})")]
        public ActionResult GetCinemaRoomById(int id)
        {
            var room = _service.GetCinemaRoomById(id);

            return Ok(room);
        }

        [HttpGet("client/{id})")]
        public ActionResult GetClientById(int id)
        {
            var room = _service.GetCinemaRoomById(id);

            return Ok(room);
        }

        [HttpGet("film/{id})")]
        public ActionResult GetFilmById(int id)
        {
            var film = _service.GetFilmById(id);

            return Ok(film);
        }

        [HttpGet("reservation/{id})")]
        public ActionResult GetReservationById(int id)
        {
            var reservation = _service.GetReservationById(id);

            return Ok(reservation);
        }

        [HttpGet("seance/{id})")]
        public ActionResult GetSeanceById(int id)
        {
            var seance = _service.GetSeanceById(id);

            return Ok(seance);
        }

        [HttpGet("user/{id})")]
        public ActionResult GetUserById(int id)
        {
            var user = _service.GetUserById(id);

            return Ok(user);
        }

        [HttpPut("reservation")]
        public ActionResult MakeReservation([FromBody]Reservation reservation)
        {
            _service.MakeReservation(reservation);

            return Ok();
        }
    }
}
