using System;
using System.Collections.Generic;
using System.Text;

namespace WZPO.DataAccess.Models
{
    public class PrivelageName
    {
        public int Id { get; set; }
        public bool CanEditSeance { get; set; }
        public bool CanEditCinemaRoom { get; set; }
        public bool CanEditUser { get; set; }
        public virtual User User { get; set; }
    }
}
