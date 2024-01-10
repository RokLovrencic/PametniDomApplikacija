using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace PametniDomAPP
{
    public class StockContext : DbContext
    {

        string path = "Database.db";
        public DbSet<Uporabnik> UporabnikDB { get; set; }
        public DbSet<Naprava> NapravaDB { get; set; }
        public DbSet<Obvestilo> ObvestiloDB { get; set; }

        public StockContext()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($"Data source={path}");
        }

        public bool ObjectExists(string usernameToCheck)
        {
            return UporabnikDB.Any(u => u.uime == usernameToCheck);
        }

        public bool PasswordMatch(string password)
        {
            return UporabnikDB.Any(p => p.geslo == password);
        }
    }
}
