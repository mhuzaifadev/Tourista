using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tourista.Models;

namespace Tourista.Data
{
    public class DBContext : DbContext
    {
        public DbSet<TouristaData> TouristaData { get; set; }
        public DBContext(DbContextOptions<DBContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<TouristaData>().HasNoKey();
        }
    }
}
