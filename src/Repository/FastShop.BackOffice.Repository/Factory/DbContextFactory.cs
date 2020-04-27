using FastShop.BackOffice.Repository.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FastShop.BackOffice.Repository.Factory
{
    public class DbContextFactory : IDesignTimeDbContextFactory<FastShopBackOfficeContext>
    {
        public FastShopBackOfficeContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();
            var builder = new DbContextOptionsBuilder<FastShopBackOfficeContext>();
            var connectionString = configuration.GetConnectionString("DefaultConnection");
            builder.UseMySql(connectionString);
            return new FastShopBackOfficeContext(builder.Options);
        }
    }
}
