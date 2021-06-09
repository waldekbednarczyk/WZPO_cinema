using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WZPO.DataAccess.Models;
using WZPO.IServices;

namespace WZPO.Controllers
{
    public class FilmController : Controller
    {
        private readonly IFilmService _service;
        public FilmController(IFilmService service)
        {
            _service = service;
        }
        public ActionResult CreateFilm(Film film)
        {
            _service.CreateFilm(film);
            return Ok();
        }
        public ActionResult DeleteFilm(Film film)
        {
            _service.DeleteFilm(film);
            return Ok();
        }
        public ActionResult EditFilm(Film film)
        {
            _service.EditFilm(film);
            return Ok();
        }
        public ActionResult<IEnumerable<Film>> GetAllFilms()
        {
            var films = _service.GetAllFilms();

            return Ok(films);
        }
        [HttpGet("film/{id})")]
        public ActionResult GetFilmById(int id)
        {
            var film = _service.GetFilmById(id);

            return Ok(film);
        }
    }
}
