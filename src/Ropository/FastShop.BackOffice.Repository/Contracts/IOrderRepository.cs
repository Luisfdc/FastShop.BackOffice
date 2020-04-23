using FastShop.BackOffice.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace FastShop.BackOffice.Repository.Contracts
{
    public interface IOrderRepository
    {
        List<Order> List(int clientId);
        Order Get(int orderId);

        int UpdateStatus(Order order);

    }
}
