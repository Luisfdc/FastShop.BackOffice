using FastShop.BackOffice.Application;
using FastShop.BackOffice.Repository;
using NUnit.Framework;
using System.Linq;

namespace Tests
{
    public class OrderItemApplicationTest
    {
        private OrderItemApplication _orderItemApp;

        [SetUp]
        public void Setup()
        {
            _orderItemApp = new OrderItemApplication(new OrderItemRepository());
        }

        [Test]
        public void List_OrderItem_test()
        {
            var orderItems = _orderItemApp.List(1);

            Assert.IsNotNull(orderItems);
        }

        [Test]
        public void List_OrderItem_test_Id_Zero()
        {
            var orderItems = _orderItemApp.List(0);

            Assert.IsFalse(orderItems.Any());
        }
    }
}