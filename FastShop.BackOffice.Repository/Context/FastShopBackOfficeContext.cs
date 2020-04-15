using FastShop.BackOffice.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace FastShop.BackOffice.Repository.Context
{
    public class FastShopBackOfficeContext : DbContext
    {

        public FastShopBackOfficeContext(DbContextOptions<FastShopBackOfficeContext> opcoes)
            : base(opcoes)
        {
        }

        public DbSet<Product> Product { get; set; }
        public DbSet<Client> Client { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<OrderItem> OrderItem { get; set; }
    }
}
