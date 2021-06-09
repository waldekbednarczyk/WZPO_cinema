using System;
using System.Collections.Generic;
using System.Text;
using WZPO.DataAccess.Models;

namespace WZPO.IServices
{
    public interface ISeanceService
    {
        Seance GetSeanceById(int id);
        IEnumerable<Seance> GetAllSeancess();
        int CreateSeance(Seance seance);
        void EditSeance(Seance seance);
        void DeleteSeance(Seance seance);
    }
}
