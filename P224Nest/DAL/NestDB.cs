using Microsoft.EntityFrameworkCore;
using P224Nest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace P224Nest.DAL
{
    public class NestDB : DbContext
    {
        public NestDB(DbContextOptions<NestDB> options) : base(options)
        {

        }

        public DbSet<About> Abouts { get; set; }
        public DbSet<AboutImage> AboutImages { get; set; }
        public DbSet<Provide> Provides { get; set; }
    }
}
