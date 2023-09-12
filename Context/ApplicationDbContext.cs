using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using SBS_NBA_DavTest.Models;
using System;
using System.Collections.Generic;



namespace SBS_NBA_DavTest.Context
{
     public class ApplicationDbContext : DbContext
     {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<NBAData> NBADataStats { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<NBAData>().ToTable("NBAData");
        }


    }
}
