using FastShop.BackOffice.Domain.Entities;
using FastShop.BackOffice.Repository.Contracts;
using FastShop.BackOffice.Repository.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FastShop.BackOffice.Repository
{
    public class ClientRepository : IClientRepository
    {
        private string[] args;
        public Client Get(string cpf)
        {
            using (var db = new DbContextFactory().CreateDbContext(args))
            {
                return db.Client.FirstOrDefault(x => x.Document == cpf);

            }
        }

        public List<Client> List()
        {
            using (var db = new DbContextFactory().CreateDbContext(args))
            {
                return db.Client.ToList();

            }
        }
    }
}
