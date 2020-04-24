using FastShop.BackOffice.Application;
using FastShop.BackOffice.Domain.Entities;
using FastShop.BackOffice.Repository;
using FastShop.BackOffice.Repository.Contracts;
using NSubstitute;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace Tests
{
    public class OrderItemApplicationTest
    {
        private OrderItemApplication _orderItemApp;

        [SetUp]
        public void Setup()
        {
            var mock = Substitute.For<IOrderItemRepository>();

            var orderItems = new List<OrderItem> {
                new OrderItem { Id = 1, OrderId = 1, ProductId = 1 }
            };

            mock.List(1)
                .Returns(orderItems);

            mock.List(0)
                .Returns(new List<OrderItem>());

            _orderItemApp = new OrderItemApplication(mock);
        }

        [Test]
        public void List_OrderItem_test()
        {
            var orderItems = _orderItemApp.List(1);

            Assert.IsTrue(orderItems.Any());
        }

        [Test]
        public void List_OrderItem_test_Id_Zero()
        {
            var orderItems = _orderItemApp.List(0);

            Assert.IsFalse(orderItems.Any());
        }
    }
}