using premozi.Models;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore;
using MySql.Data.MySqlClient;


namespace premozi.Models
{
    public class DataBaseContext : DbContext
    {
        public DataBaseContext(DbContextOptions options):base(options) { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "server=localhost;user=root;password=;database=premozi;";
            var serverVersion = new MySqlServerVersion(new Version(10, 4, 32));
            optionsBuilder.UseMySql(connectionString, serverVersion);
        }
        public DbSet<Film> Film { get; set; }
        public DbSet<Terem> Terem { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Vetites> Vetites { get; set; }
        public DbSet<Rendeles> Rendeles { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
