using Microsoft.EntityFrameworkCore;

namespace SBS_NBA_DavTest.Models
{
    public class TeamPlayer
    {
        public class ApplicationDbContext : DbContext
        {
            public DbSet<NBATeam> NBATeams { get; set; }
            public DbSet<Player> Players { get; set; }

            // No DbSet for TeamPlayer, as Entity Framework will handle it implicitly

            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                // Configure the many-to-many relationship
                modelBuilder.Entity<TeamPlayer>()
                    .HasKey(tp => new { tp.TeamID, tp.PlayerID });

                modelBuilder.Entity<TeamPlayer>()
                    .HasOne(tp => tp.NBATeam)
                    .WithMany(t => t.Players)
                    .HasForeignKey(tp => tp.TeamID);

                modelBuilder.Entity<TeamPlayer>()
                    .HasOne(tp => tp.Player)
                    .WithMany(p => p.Teams)
                    .HasForeignKey(tp => tp.PlayerID);
            }
        }

    }
}
