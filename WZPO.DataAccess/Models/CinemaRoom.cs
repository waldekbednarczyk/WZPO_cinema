using System;
using System.Collections.Generic;
using System.Text;

namespace WZPO.DataAccess.Models
{
    public class CinemaRoom
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public int ScreenSize { get; set; }
        public virtual ICollection<Seat> Seats { get; set; }
    }
}
