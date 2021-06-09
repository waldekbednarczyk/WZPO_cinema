using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WZPO.DataAccess.Context;
using WZPO.DataAccess.Models;
using WZPO.IServices;

namespace WZPO.Services
{
    public class FilmService : IFilmService
    {
        private readonly CinemaDbContext _dbContext;
        public FilmService(CinemaDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public int CreateFilm(Film film)
        {
            _dbContext.Films.Add(film);
            _dbContext.SaveChanges();
            return film.Id;
        }
        public void DeleteFilm(Film film)
        {
            _dbContext.Films.Remove(film);
            _dbContext.SaveChanges();
        }
        public void EditFilm(Film film)
        {
            var _film = _dbContext.Films.Where(f => f.Id == film.Id).FirstOrDefault();
            if (_film == null) return;

            _film.Description = film.Description;
            _film.ReleaseDate = film.ReleaseDate;
            _film.Title = film.Title;
            _dbContext.SaveChanges();
        }
        public IEnumerable<Film> GetAllFilms()
        {
            return _dbContext.Films;
        }
        public Film GetFilmById(int id)
        {
            return _dbContext.Films.Where(r => r.Id == id).FirstOrDefault();
        }
    }
}
