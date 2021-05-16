using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using WZPO.DataAccess.Models;

namespace WZPO.DataAccess.Context
{
    public class CinemaDbContext : DbContext
    {
        public CinemaDbContext(DbContextOptions<CinemaDbContext> options) : base(options)
        {
        }

        public virtual DbSet<Administrator> Administrators { get; set; }
        public virtual DbSet<CinemaRoom> CinemaRooms { get; set; }
        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<Film> Films { get; set; }
        public virtual DbSet<Price> Prices { get; set; }
        public virtual DbSet<Reservation> Reservations { get; set; }
        public virtual DbSet<Seance> Seances { get; set; }
        public virtual DbSet<Seat> Seats { get; set; }
        public virtual DbSet<Ticket> Ticket { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
