using Microsoft.EntityFrameworkCore;
using Repository.Entities;

namespace Repository.Db_Context
{
    public class CinemaDbContext: DbContext
    {
        public DbSet<Auditorium> Auditoriums { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Client> Clients { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseSqlServer(@"Server=localhost;Database=master;Trusted_Connection=True;");
        }
    }
}
