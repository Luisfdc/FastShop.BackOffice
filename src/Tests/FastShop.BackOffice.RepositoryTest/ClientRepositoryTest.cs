using FastShop.BackOffice.Domain.Entities;
using FastShop.BackOffice.Repository;
using FastShop.BackOffice.Repository.Contracts;
using NSubstitute;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace Tests
{
    public class ClientRepositoryTest
    {
        private IClientRepository _clientRep;

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

            _clientRep = mock;
        }

        [Test]
        public void List_Client_test()
        {
            var clients = _clientRep.List();

            Assert.IsNotNull(clients);
        }


        [Test]
        public void Get_Client_test()
        {
            var clients = _clientRep.Get("39681706013");

            Assert.IsNotNull(clients);
        }
    }
}