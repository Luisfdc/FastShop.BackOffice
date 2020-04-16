using FastShop.BackOffice.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace FastShop.BackOffice.Application.Contracts
{
    public interface IOrderApplication
    {
        List<Order> List(int clientId);
        Order Get(int orderId);

        void UpdateStatus(Order order);
    }
}
