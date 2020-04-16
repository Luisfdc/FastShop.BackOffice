using FastShop.BackOffice.Application.Contracts;
using FastShop.BackOffice.Domain.Entities;
using FastShop.BackOffice.Repository.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace FastShop.BackOffice.Application
{
    public class OrderItemApplication : IOrderItemApplication
    {
        private readonly IOrderItemRepository _orderItemRepository;

        public OrderItemApplication(IOrderItemRepository orderItemRepository)
        {
            _orderItemRepository = orderItemRepository;
        }
        public List<OrderItem> List(int orderId)
        {
            return _orderItemRepository.List(orderId);
        }
    }
}
