using FastShop.BackOffice.Application;
using FastShop.BackOffice.Application.Contracts;
using FastShop.BackOffice.Domain.Entities;
using FastShop.BackOffice.Domain.Enum;
using FastShop.BackOffice.Repository;
using NUnit.Framework;

namespace Tests
{
    public class OrderApplicationTest
    {
        private IOrderApplication _orderApp;

        [SetUp]
        public void Setup()
        {
            _orderApp = new OrderApplication(new OrderRepository());
        }

        [Test]
        public void List_Order_Test()
        {
            var clients = _orderApp.List(1);

            Assert.IsNotNull(clients);
        }


        [Test]
        public void Get_Order_Test()
        {
            var clients = _orderApp.Get(1);

            Assert.IsNotNull(clients);
        }




        [Test]
        public void UpdateStatus_Order_Test()
        {
            var order = new Order { Id = 1, Status = OrderStatusEnum.Pending };

            _orderApp.UpdateStatus(order);

            var saveOrder = _orderApp.Get(1);

            Assert.IsTrue(saveOrder.Status == OrderStatusEnum.Pending);
        }

        [Test]
        public void Get_Order_Test__Id_Zero()
        {
            var clients = _orderApp.Get(0);

            Assert.IsNull(clients);
        }
    }
}