using FastShop.BackOffice.Repository;
using FastShop.BackOffice.Repository.Contracts;
using NUnit.Framework;

namespace Tests
{
    public class ClientRepositoryTest
    {
        private IClientRepository _clientRep;

        [SetUp]
        public void Setup()
        {
            _clientRep = new ClientRepository();
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