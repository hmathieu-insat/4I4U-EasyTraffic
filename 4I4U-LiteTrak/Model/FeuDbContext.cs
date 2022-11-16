using Microsoft.EntityFrameworkCore;

namespace _4I4U_LiteTrak.Model
{
    public class FeuDbContext : DbContext
    {
        public DbSet<Feu> Feus { get; set; }

        public string DbPath { get; }

        public FeuDbContext()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);

            DbPath = DbPath = System.IO.Path.Join(path, "feus.db");
        }

        // The following configures EF to create a Sqlite database file in the
        // special "local" folder for your platform.
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite($"Data Source={DbPath}");
    }
}
