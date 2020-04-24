using FastShop.BackOffice.Application;
using FastShop.BackOffice.Application.Contracts;
using FastShop.BackOffice.Domain.Entities;
using FastShop.BackOffice.Domain.Enum;
using FastShop.BackOffice.Repository;
using FastShop.BackOffice.Repository.Contracts;
using NSubstitute;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace Tests
{
    public class OrderApplicationTest
    {
        private IOrderApplication _orderApp;

        [SetUp]
        public void Setup()
        {
            var mock = Substitute.For<IOrderRepository>();

            var orders = new List<Order> {
                new Order { Id = 1, ClientId = 1, Status = OrderStatusEnum.Pending  }
            };

            mock.List(1)
                .Returns(orders);

            mock.Get(1)
                .Returns(orders.FirstOrDefault());

            mock.List(0)
                .Returns(new List<Order>());

            mock.UpdateStatus(new Order { Id = 1, Status = OrderStatusEnum.Pending })
                .Returns(1);

            _orderApp = new OrderApplication(mock);
        }

        [Test]
        public void List_Order_Test()
        {
            var orders = _orderApp.List(1);

            Assert.IsNotNull(orders);
        }


        [Test]
        public void Get_Order_Test()
        {
            var order = _orderApp.Get(1);

            Assert.IsNotNull(order);
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