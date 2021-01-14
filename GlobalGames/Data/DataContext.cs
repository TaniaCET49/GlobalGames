
using GlobalGames.Data.Entidades;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace GlobalGames.Data
{
    public class DataContext : IdentityDbContext<User>
    {

        public DbSet<Contactos> Contactos { get; set; }

        public DbSet<Inscricoes> Inscricoes { get; set; }

        public DbSet<UserLogin> UserLogin { get; set; }

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        
    }
}
