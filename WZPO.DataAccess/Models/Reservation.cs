using System;
using System.Collections.Generic;
using System.Text;

namespace WZPO.DataAccess.Models
{
    public class Reservation
    {
        public int Id { get; set; }
        public User User { get; set; }
        public Seance Seance { get; set; }
        public ICollection<Seat> Seats { get; set; }
        public ICollection<Ticket> Ticket { get; set; }
        public bool Paid { get; set; }
    }
}
