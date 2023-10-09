using Dominio.Entidades.Usuarios;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructura
{
    public class UsuariosDbContext: DbContext
    {
        public DbSet<Usuarios> Usuarios { get; set; }
        public DbSet<Perfil> Perfiles { get; set; }
        public DbSet<Organizacion> Organizacions { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                const string connectionString = "Server=localhost;Database=usuarios;Trusted_Connection=true;";
                optionsBuilder.UseSqlServer(connectionString);
            }
        }
    }
}
