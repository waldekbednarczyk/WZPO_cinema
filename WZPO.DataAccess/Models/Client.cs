using System;
using System.Collections.Generic;
using System.Text;

namespace WZPO.DataAccess.Models
{
    public class Client : User
    {
        public ICollection<Reservation> Reservations { get; set; }
    }
}
