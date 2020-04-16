using FastShop.BackOffice.Application.Contracts;
using FastShop.BackOffice.Domain.Entities;
using FastShop.BackOffice.Repository.Contracts;
using System.Collections.Generic;

namespace FastShop.BackOffice.Application
{
    public class OrderApplication : IOrderApplication
    {
        private readonly IOrderRepository _orderRepository;

        public OrderApplication(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }
        public Order Get(int orderId)
        {
            return _orderRepository.Get(orderId);
        }

        public List<Order> List(int clientId)
        {
            return _orderRepository.List(clientId);
        }

        public void UpdateStatus(Order order)
        {
            _orderRepository.UpdateStatus(order);
        }
    }
}
