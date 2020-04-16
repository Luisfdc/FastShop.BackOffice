using FastShop.BackOffice.Repository;
using FastShop.BackOffice.Repository.Contracts;
using NUnit.Framework;
using System.Linq;

namespace Tests
{
    public class OrderItemRepositoryTest
    {
        private IOrderItemRepository _orderItemRep;

        [SetUp]
        public void Setup()
        {
            _orderItemRep = new OrderItemRepository();
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