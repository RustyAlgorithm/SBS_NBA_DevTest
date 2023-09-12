using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using SBS_NBA_DavTest.Models;
using System;
using System.Collections.Generic;



namespace SBS_NBA_DavTest.Context
{
     public class ApplicationDbContext : DbContext
     {
        public DbSet<NBATeam> NBATeams { get; set; }
        public DbSet<Player> Players { get; set; }
        public DbSet<Game> Games { get; set; }


        public List<NBATeam> GetNBATeams()
        {
            return this.NBATeams.FromSqlRaw("EXEC ClaculateNBAData").ToList();
        }


    }
}
