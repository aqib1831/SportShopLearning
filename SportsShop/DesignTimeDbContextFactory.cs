using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using SportsShop.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace SportsShop
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
    {
        public ApplicationDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();
            var builder = new DbContextOptionsBuilder<ApplicationDbContext>();
            var connectionString = configuration.GetConnectionString("SportStoreProducts");
            builder.UseSqlServer(connectionString);
          //var  builder1 = new DbContextOptionsBuilder<AppIdentityDbContext>();
          //  connectionString = configuration.GetConnectionString("SportStoreIdentity");
            //builder1.UseSqlServer(connectionString);
            return new ApplicationDbContext(builder.Options);
        }
    }
}
