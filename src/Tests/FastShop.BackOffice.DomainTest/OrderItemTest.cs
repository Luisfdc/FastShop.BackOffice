using FastShop.BackOffice.Domain.Entities;
using NUnit.Framework;

namespace Tests
{
    public class OrderItemTest
    {
        private Product _product;
        private OrderItem _orderItem;

        [SetUp]
        public void Setup()
        {
            _product = new Product() { Id = 1, Description = "Notebook", Price = 1000 };
            _orderItem = new OrderItem(1, 5) { Product = _product };
        }

        [Test]
        public void AddQtdTest()
        {
            _orderItem.AddQtd(5);

            Assert.IsTrue(_orderItem.Qtd == 10);
        }



        [Test]
        public void TotalPartialTest()
        {
            var total = _orderItem.TotalPartial();

            Assert.IsTrue(total == 5000);
        }
    }
}