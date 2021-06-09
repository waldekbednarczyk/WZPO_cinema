using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WZPO.DataAccess.Context;
using WZPO.DataAccess.Models;
using WZPO.IServices;

namespace WZPO.Services
{
    class SeanceService : ISeanceService
    {
        private readonly CinemaDbContext _dbContext;
        public SeanceService(CinemaDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public int CreateSeance(Seance seance)
        {
            _dbContext.Seances.Add(seance);
            _dbContext.SaveChanges();
            return seance.Id;
        }
        public void DeleteSeance(Seance seance)
        {
            _dbContext.Seances.Remove(seance);
            _dbContext.SaveChanges();
        }
        public void EditSeance(Seance seance)
        {
            var _seance = _dbContext.Seances.Where(s => s.Id == seance.Id).FirstOrDefault();
            if (_seance == null) return;

            _seance.Films = seance.Films;
            _seance.Date = seance.Date;
            _seance.CinemaRoom = seance.CinemaRoom;
            _dbContext.SaveChanges();
        }
        public IEnumerable<Seance> GetAllSeancess()
        {
            return _dbContext.Seances;
        }
        public Seance GetSeanceById(int id)
        {
            return _dbContext.Seances.Where(r => r.Id == id).FirstOrDefault();
        }

    }
}
