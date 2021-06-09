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
        public void DeleteCinemaRoom(CinemaRoom cinemaRoom)
        {
            _dbContext.CinemaRooms.Remove(cinemaRoom);
            _dbContext.SaveChanges();
        }
        public void EditCinemaRoom(CinemaRoom cinemaRoom)
        {
            throw new NotImplementedException();
        }
        public IEnumerable<CinemaRoom> GetAllCinemaRooms()
        {
            return _dbContext.CinemaRooms;
        }
        public CinemaRoom GetCinemaRoomById(int id)
        {
            return _dbContext.CinemaRooms.Where(r => r.Id == id).FirstOrDefault();
        }
    }
}
