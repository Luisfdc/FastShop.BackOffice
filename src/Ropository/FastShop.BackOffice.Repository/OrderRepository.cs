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
    public class OrderRepository : IOrderRepository
    {
        private string[] args;

        public OrderRepository()
        {
        }

        public Order Get(int orderId)
        {
            using (var db = new DbContextFactory().CreateDbContext(args))
            {
                var order = db.Order.Include(x => x.Client).FirstOrDefault(x => x.Id == orderId);

                if (order != null)
                    order.Items = db.OrderItem.Where(item => item.OrderId == orderId).Include(y => y.Product).ToList();

                return order;
            }
        }

        public List<Order> List(int clientId)
        {
            using (var db = new DbContextFactory().CreateDbContext(args))
            {
                var orders = db.Order.Where(x => x.ClientId == clientId).Include(x => x.Client).ToList();

                if (orders != null)
                    orders.ForEach(x => x.Items = db.OrderItem.Where(item => item.OrderId == x.Id).Include(y => y.Product).ToList());

                return orders;
            }
        }

        public void UpdateStatus(Order order)
        {
            using (var db = new DbContextFactory().CreateDbContext(args))
            {
                var entity = db.Order.FirstOrDefault(item => item.Id == order.Id);

                entity.Status = order.Status;
                order.UpdateAt = DateTime.Now;
                entity.UpdateAt = DateTime.Now;

                db.Order.Update(entity);

                db.SaveChanges();

            }
        }
    }
}
