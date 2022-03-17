using Microsoft.EntityFrameworkCore;
using P224DbContext.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace P224DbContext.DAL
{
    public class DbContextP224 : DbContext
    {
        public DbContextP224(DbContextOptions<DbContextP224> options) : base(options){ }

        public DbSet<Student> Students { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<StudentGroup> StudentGroups { get; set; }
    }
}
