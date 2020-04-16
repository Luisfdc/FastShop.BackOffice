using FastShop.BackOffice.Application;
using FastShop.BackOffice.Repository;
using NUnit.Framework;

namespace Tests
{
    public class ClientApplicationTest
    {
        private ClientApplication _clientApp;

        [SetUp]
        public void Setup()
        {
            _clientApp = new ClientApplication(new ClientRepository());
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