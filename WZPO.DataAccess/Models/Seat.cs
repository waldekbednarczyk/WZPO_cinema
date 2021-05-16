using System;
using System.Collections.Generic;
using System.Text;

namespace WZPO.DataAccess.Models
{
    public class Seat
    {
        public int Id { get; set; }
        public int Row { get; set; }
        public int Column { get; set; }
        public bool IsVip { get; set; }
    }
}
