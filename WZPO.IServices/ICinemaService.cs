using System;
using System.Collections.Generic;
using System.Text;
using WZPO.DataAccess.Models;

namespace WZPO.Services
{
    public interface ICinemaService
    {
        int AddCinemaRoom(CinemaRoom cinemaRoom);
        void EditCinemaRoom(CinemaRoom cinemaRoom);
        CinemaRoom GetCinemaRoomById(int id);
        IEnumerable<CinemaRoom> GetAllCinemaRooms();
        void DeleteCinemaRoom(CinemaRoom cinemaRoom);
    }
}
