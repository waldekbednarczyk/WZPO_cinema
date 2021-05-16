using System;
using System.Collections.Generic;
using System.Text;

namespace WZPO.DataAccess.Models
{
    public class Seance
    {
        public int Id { get; set; }
        public ICollection<Film> Films { get; set; }
        public CinemaRoom CinemaRoom { get; set; }
        public DateTime Date { get; set; }
    }
}
