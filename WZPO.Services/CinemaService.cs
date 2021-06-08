using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WZPO.DataAccess.Context;
using WZPO.DataAccess.Models;

namespace WZPO.Services
{
    public class CinemaService : ICinemaService
    {
        private readonly CinemaDbContext _dbContext;
        public CinemaService(CinemaDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public int AddCinemaRoom(CinemaRoom cinemaRoom)
        {
            _dbContext.CinemaRooms.Add(cinemaRoom);
            _dbContext.SaveChanges();
            return cinemaRoom.Id;
        }

        public void CancelReservation(Reservation reservation)
        {
            throw new NotImplementedException();
        }

        public int CreateClient(Client client)
        {
            _dbContext.Clients.Add(client);
            _dbContext.SaveChanges();
            return client.Id;
        }

        public int CreateFilm(Film film)
        {
            _dbContext.Films.Add(film);
            _dbContext.SaveChanges();
            return film.Id;
        }

        public int CreateSeance(Seance seance)
        {
            _dbContext.Seances.Add(seance);
            _dbContext.SaveChanges();
            return seance.Id;
        }

        public int CreateUser(User user)
        {
            _dbContext.Users.Add(user);
            _dbContext.SaveChanges();
            return user.Id;
        }

        public void DeleteCinemaRoom(CinemaRoom cinemaRoom)
        {
            _dbContext.CinemaRooms.Remove(cinemaRoom);
            _dbContext.SaveChanges();
        }

        public void DeleteClient(Client client)
        {
            _dbContext.Clients.Remove(client);
            _dbContext.SaveChanges();
        }

        public void DeleteFilm(Film film)
        {
            _dbContext.Films.Remove(film);
            _dbContext.SaveChanges();
        }

        public void DeleteSeance(Seance seance)
        {
            _dbContext.Seances.Remove(seance);
            _dbContext.SaveChanges();
        }

        public void DeleteUser(User user)
        {
            _dbContext.Users.Remove(user);
            _dbContext.SaveChanges();
        }

        public void EditCinemaRoom(CinemaRoom cinemaRoom)
        {
            throw new NotImplementedException();
        }

        public void EditClient(Client client)
        {
            var _client = _dbContext.Clients.Where(c => c.Id == client.Id).FirstOrDefault();
            if (_client == null) return;

            _client.Email = client.Email;
            _client.Name = client.Name;
            _client.Reservations = client.Reservations;
            _client.Surname = client.Surname;

            _dbContext.SaveChanges();
        }

        public void EditUser(User user)
        {
            var _user = _dbContext.Users.Where(u => u.Id == user.Id).FirstOrDefault();
            if (_user == null) return;

            _user.Email = user.Email;
            _user.Name = user.Name;
            _user.Surname = user.Surname;
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

        public void EditSeance(Seance seance)
        {
            var _seance =_dbContext.Seances.Where(s => s.Id == seance.Id).FirstOrDefault();
            if (_seance == null) return;

            _seance.Films = seance.Films;
            _seance.Date = seance.Date;
            _seance.CinemaRoom = seance.CinemaRoom;
            _dbContext.SaveChanges();
        }

        public IEnumerable<CinemaRoom> GetAllCinemaRooms()
        {
            return _dbContext.CinemaRooms;
        }

        public IEnumerable<Client> GetAllClients()
        {
            return _dbContext.Clients;
        }

        public IEnumerable<Film> GetAllFilms()
        {
            return _dbContext.Films;
        }

        public IEnumerable<Reservation> GetAllReservations()
        {
            return _dbContext.Reservations;
        }

        public IEnumerable<Seance> GetAllSeancess()
        {
            return _dbContext.Seances;
        }

        public IEnumerable<User> GetAllUsers()
        {
            return _dbContext.Users;
        }

        public CinemaRoom GetCinemaRoomById(int id)
        {
            return _dbContext.CinemaRooms.Where(r => r.Id == id).FirstOrDefault();
        }

        public Client GetClientById(int id)
        {
            return _dbContext.Clients.Where(r => r.Id == id).FirstOrDefault();
        }

        public Film GetFilmById(int id)
        {
            return _dbContext.Films.Where(r => r.Id == id).FirstOrDefault();
        }

        public Reservation GetReservationById(int id)
        {
            return _dbContext.Reservations.Where(r => r.Id == id).FirstOrDefault();
        }

        public Seance GetSeanceById(int id)
        {
            return _dbContext.Seances.Where(r => r.Id == id).FirstOrDefault();
        }

        public User GetUserById(int id)
        {
            return _dbContext.Users.Where(r => r.Id == id).FirstOrDefault();
        }

        public void MakeReservation(Reservation reservation)
        {
            _dbContext.Reservations.Add(reservation);
            _dbContext.SaveChanges();
        }
    }
}
