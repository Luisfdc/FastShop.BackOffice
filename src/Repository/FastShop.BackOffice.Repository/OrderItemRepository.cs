using FastShop.BackOffice.Domain.Entities;
using FastShop.BackOffice.Repository.Contracts;
using FastShop.BackOffice.Repository.Factory;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FastShop.BackOffice.Repository
{
    public class OrderItemRepository : IOrderItemRepository
    {
        private string[] args;
        public List<OrderItem> List(int orderId)
        {
            using (var db = new DbContextFactory().CreateDbContext(args))
            {
                return db.OrderItem.Where(x => x.OrderId == orderId).Include(x => x.Product).ToList();

            }
        }
    }
}
