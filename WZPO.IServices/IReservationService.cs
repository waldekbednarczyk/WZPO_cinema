using System;
using System.Collections.Generic;
using System.Text;
using WZPO.DataAccess.Models;

namespace WZPO.IServices
{
    public interface IReservationService
    {
        void MakeReservation(Reservation reservation);
        void CancelReservation(Reservation reservation);
        Reservation GetReservationById(int id);
        IEnumerable<Reservation> GetAllReservations();
    }
}
