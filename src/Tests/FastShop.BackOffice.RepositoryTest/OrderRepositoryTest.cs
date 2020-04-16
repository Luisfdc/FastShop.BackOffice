using FastShop.BackOffice.Domain.Entities;
using FastShop.BackOffice.Domain.Enum;
using FastShop.BackOffice.Repository;
using FastShop.BackOffice.Repository.Contracts;
using NUnit.Framework;

namespace Tests
{
    public class OrderRepositoryTest
    {
        private IOrderRepository _orderRep;

        [SetUp]
        public void Setup()
        {
            _orderRep = new OrderRepository();
        }

        [Test]
        public void List_Order_Test()
        {
            var clients = _orderRep.List();

            Assert.IsNotNull(clients);
        }


        [Test]
        public void Get_Order_Test()
        {
            var clients = _orderRep.Get(1);

            Assert.IsNotNull(clients);
        }


        [Test]
        public void UpdateStatus_Order_Test()
        {
            var order = new Order { Id = 1, Status = OrderStatusEnum.Pending };

            _orderRep.UpdateStatus(order);

            var saveOrder = _orderRep.Get(1);

            Assert.IsTrue(saveOrder.Status == OrderStatusEnum.Pending);
        }


        [Test]
        public void Get_Order_Test__Id_Zero()
        {
            var clients = _orderRep.Get(0);

            Assert.IsNull(clients);
        }
    }
}