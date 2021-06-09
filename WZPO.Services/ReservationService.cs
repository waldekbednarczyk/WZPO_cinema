using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WZPO.DataAccess.Context;
using WZPO.DataAccess.Models;
using WZPO.IServices;

namespace WZPO.Services
{
    public class ReservationService : IReservationService
    {
        private readonly CinemaDbContext _dbContext;
        public ReservationService(CinemaDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void CancelReservation(Reservation reservation)
        {
            throw new NotImplementedException();
        }
        public IEnumerable<Reservation> GetAllReservations()
        {
            return _dbContext.Reservations;
        }
        public Reservation GetReservationById(int id)
        {
            return _dbContext.Reservations.Where(r => r.Id == id).FirstOrDefault();
        }
        public void MakeReservation(Reservation reservation)
        {
            _dbContext.Reservations.Add(reservation);
            _dbContext.SaveChanges();
        }

    }
}
