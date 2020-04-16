using FastShop.BackOffice.Application.Contracts;
using FastShop.BackOffice.Domain.Entities;
using FastShop.BackOffice.Repository.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace FastShop.BackOffice.Application
{
    public class ClientApplication : IClientApplication
    {
        private readonly IClientRepository _clientRepository;

        public ClientApplication(IClientRepository clientRepository)
        {
            _clientRepository = clientRepository;
        }
        public Client Get(string cpf)
        {
            return _clientRepository.Get(cpf);
        }

        public List<Client> List()
        {
            return _clientRepository.List();
        }
    }
}
