using System;
using System.Collections.Generic;
using System.Text;
using WZPO.DataAccess.Models;

namespace WZPO.Services
{
    public interface ICinemaService
    {
        Client GetClientById(int id);
        IEnumerable<Client> GetAllClients();
        int CreateClient(Client client);
        void EditClient(Client client);
        void DeleteClient(Client client);
        void MakeReservation(Reservation reservation);
        void CancelReservation(Reservation reservation);
        Reservation GetReservationById(int id);
        IEnumerable<Reservation> GetAllReservations();
        int AddCinemaRoom(CinemaRoom cinemaRoom);
        void EditCinemaRoom(CinemaRoom cinemaRoom);
        CinemaRoom GetCinemaRoomById(int id);
        IEnumerable<CinemaRoom> GetAllCinemaRooms();
        void DeleteCinemaRoom(CinemaRoom cinemaRoom);
        User GetUserById(int id);
        IEnumerable<User> GetAllUsers();
        int CreateUser(User user);
        void EditUser(User user);
        void DeleteUser(User user);
        Film GetFilmById(int id);
        IEnumerable<Film> GetAllFilms();
        int CreateFilm(Film film);
        void EditFilm(Film film);
        void DeleteFilm(Film film);
        Seance GetSeanceById(int id);
        IEnumerable<Seance> GetAllSeancess();
        int CreateSeance(Seance seance);
        void EditSeance(Seance seance);
        void DeleteSeance(Seance seance);

    }
}
