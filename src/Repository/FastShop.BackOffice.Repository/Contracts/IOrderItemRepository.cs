using FastShop.BackOffice.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace FastShop.BackOffice.Repository.Contracts
{
    public interface IOrderItemRepository
    {
        List<OrderItem> List(int orderId);
    }
}
