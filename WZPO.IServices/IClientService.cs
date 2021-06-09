using System;
using System.Collections.Generic;
using System.Text;
using WZPO.DataAccess.Models;

namespace WZPO.IServices
{
    public interface IClientService
    {
        Client GetClientById(int id);
        IEnumerable<Client> GetAllClients();
        int CreateClient(Client client);
        void EditClient(Client client);
        void DeleteClient(Client client);
    }
}
