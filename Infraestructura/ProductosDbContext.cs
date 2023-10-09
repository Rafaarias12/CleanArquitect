using Dominio.Entidades.Productos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructura
{
    public class ProductosDbContext : DbContext
    {
        public DbSet<Productos> Productos { get; set; }
        public DbSet<Tipo> Tipo { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                const string connectionString = "Server=BG-AUXDESARROLL;Database=productos;Trusted_Connection=True;user=sa;password=Bio123456";
                optionsBuilder.UseSqlServer(connectionString);
            }
        }
    }
}
