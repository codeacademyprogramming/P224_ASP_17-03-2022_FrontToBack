using Microsoft.EntityFrameworkCore;
using P224ProductCategory.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace P224ProductCategory.DAL
{
    public class AmilMarketDbContext : DbContext
    {
        public AmilMarketDbContext(DbContextOptions<AmilMarketDbContext> options) : base(options){}

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
