using FastShop.BackOffice.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace FastShop.BackOffice.Repository.Contracts
{
    public interface IOrderRepository
    {
        List<Order> List();
        Order Get(int orderId);

        void UpdateStatus(Order order);

    }
}
