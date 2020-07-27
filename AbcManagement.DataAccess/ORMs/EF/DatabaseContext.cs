using AbcManagement.Entities.Concreate;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbcManagement.DataAccess.ORMs.EF
{
    public class DatabaseContext : DbContext
    {
        private readonly DatabaseContext _context;
        public DatabaseContext()
        {

        }
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
        }

        override protected void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Work> Works { get; set; }
        public DbSet<WorkUser> WorkUsers { get; set; }
    }
}
