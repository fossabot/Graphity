﻿using Microsoft.EntityFrameworkCore;

namespace Graphity.Tests.Fixtures.Data
{
    public class TestContext : DbContext
    {
        public TestContext(DbContextOptions<TestContext> options)
            : base(options)
        { }

        public DbSet<Animal> Animals { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<CountryProperties> CountryProperties { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Country>(builder =>
            {
                builder.HasKey(c => c.Id);
            });

            modelBuilder.Entity<CountryProperties>(builder =>
            {
                builder.HasKey(c => c.CountryId);
            });

            modelBuilder.Entity<Animal>(builder =>
            {
                builder.HasKey(a => a.Id);
            });
        }

    }
}