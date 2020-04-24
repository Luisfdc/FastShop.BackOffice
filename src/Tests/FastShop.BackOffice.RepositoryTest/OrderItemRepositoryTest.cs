using FastShop.BackOffice.Domain.Entities;
using FastShop.BackOffice.Repository;
using FastShop.BackOffice.Repository.Contracts;
using NSubstitute;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace Tests
{
    public class OrderItemRepositoryTest
    {
        private IOrderItemRepository _orderItemRep;

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

            _orderItemRep = mock;
        }

        [Test]
        public void List_OrderItem_test()
        {
            var orderItems = _orderItemRep.List(1);

            Assert.IsNotNull(orderItems);
        }

        [Test]
        public void List_OrderItem_test_Id_Zero()
        {
            var orderItems = _orderItemRep.List(0);

            Assert.IsFalse(orderItems.Any());
        }
    }
}