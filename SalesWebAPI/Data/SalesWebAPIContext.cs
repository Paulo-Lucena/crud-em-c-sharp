using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SalesWebAPI.Models;

namespace SalesWebAPI.Data
{
    public class SalesWebAPIContext : DbContext
    {
        public SalesWebAPIContext(DbContextOptions<SalesWebAPIContext> options)
            : base(options)
        {
        }

        public DbSet<Department>? Department { get; set; }
        public DbSet<Seller> Seller { get; set; }
        public DbSet<SalesRecord> SalesRecord { get; set; }
    }
}
