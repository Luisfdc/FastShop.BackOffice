using FastShop.BackOffice.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace FastShop.BackOffice.Repository.Contracts
{
    public interface IClientRepository
    {
        List<Client> List();
        Client Get(int clientId);
    }
}
