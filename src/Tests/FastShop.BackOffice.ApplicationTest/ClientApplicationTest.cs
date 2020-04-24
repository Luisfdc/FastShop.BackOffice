using FastShop.BackOffice.Application;
using FastShop.BackOffice.Domain.Entities;
using FastShop.BackOffice.Repository;
using FastShop.BackOffice.Repository.Context;
using FastShop.BackOffice.Repository.Contracts;
using Microsoft.EntityFrameworkCore;
using Moq;
using NSubstitute;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace Tests
{
    public class ClientApplicationTest
    {
        private ClientApplication _clientApp;

        [SetUp]
        public void Setup()
        {
            var mock = Substitute.For<IClientRepository>();

            var clients = new List<Client> { 
                new Client {Id = 1, Name = "Maria", Document = "39681706013"}
            };

            mock.Get("39681706013")
                .Returns(clients.FirstOrDefault());

            mock.List()
                .Returns(clients);

            _clientApp = new ClientApplication(mock);
        }

        [Test]
        public void List_Client_test()
        {
            var clients = _clientApp.List();

            Assert.IsNotNull(clients);
        }


        [Test]
        public void Get_Client_test()
        {
            var clients = _clientApp.Get("39681706013");

            Assert.IsNotNull(clients);
        }

    }
}