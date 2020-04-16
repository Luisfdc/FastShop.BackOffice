using FastShop.BackOffice.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace FastShop.BackOffice.Application.Contracts
{
    public interface IOrderItemApplication
    {
        List<OrderItem> List(int orderId);
    }
}
