using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WZPO.DataAccess.Context;
using WZPO.DataAccess.Models;
using WZPO.IServices;

namespace WZPO.Services
{
    public class ClientService : IClientService
    {
        private readonly CinemaDbContext _dbContext;
        public ClientService(CinemaDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public int CreateClient(Client client)
        {
            _dbContext.Clients.Add(client);
            _dbContext.SaveChanges();
            return client.Id;
        }
        public void DeleteClient(Client client)
        {
            _dbContext.Clients.Remove(client);
            _dbContext.SaveChanges();
        }
        public void EditClient(Client client)
        {
            var _client = _dbContext.Clients.Where(c => c.Id == client.Id).FirstOrDefault();
            if (_client == null) return;

            _client.Email = client.Email;
            _client.Name = client.Name;
            _client.Reservations = client.Reservations;
            _client.Surname = client.Surname;

            _dbContext.SaveChanges();
        }
        public IEnumerable<Client> GetAllClients()
        {
            return _dbContext.Clients;
        }
        public Client GetClientById(int id)
        {
            return _dbContext.Clients.Where(r => r.Id == id).FirstOrDefault();
        }
    }
}
