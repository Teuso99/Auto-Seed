using AutoSeed.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoSeed.Data
{
    public class AutoSeedDbContext : DbContext
    {
        public AutoSeedDbContext(DbContextOptions<AutoSeedDbContext> options) : base (options)
        {

        }

        public DbSet<User> User { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            SeedData.Init(5);

            modelBuilder.Entity<User>().HasData(SeedData.Users);
        }
    }

    

}
