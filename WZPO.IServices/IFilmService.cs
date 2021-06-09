using System;
using System.Collections.Generic;
using System.Text;
using WZPO.DataAccess.Models;

namespace WZPO.IServices
{
    public interface IFilmService
    {
        Film GetFilmById(int id);
        IEnumerable<Film> GetAllFilms();
        int CreateFilm(Film film);
        void EditFilm(Film film);
        void DeleteFilm(Film film);
    }
}
