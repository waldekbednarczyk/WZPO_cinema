using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace WZPO.DataAccess.Models
{
    public class Ticket
    {
        [Key]
        [Required]
        public int Id { get; set; }
        public Price Price { get; set; }
        public Seat Seat { get; set; }
        public User User { get; set; }
        public Reservation Reservation { get; set; }
    }
}
