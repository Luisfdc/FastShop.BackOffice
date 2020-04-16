using FastShop.BackOffice.Domain.Entities;
using FastShop.BackOffice.Repository.Contracts;
using FastShop.BackOffice.Repository.Factory;
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
                return db.Order.FirstOrDefault(x => x.Id == orderId);

            }
        }

        public List<Order> List()
        {
            using (var db = new DbContextFactory().CreateDbContext(args))
            {
                return db.Order.ToList();

            }
        }

        public void UpdateStatus(Order order)
        {
            using (var db = new DbContextFactory().CreateDbContext(args))
            {
                var entity = db.Order.FirstOrDefault(item => item.Id == order.Id);

                entity.Status = order.Status;

                db.Order.Update(entity);

                db.SaveChanges();

            }
        }
    }
}
