using Microsoft.EntityFrameworkCore;
using Prueba2.Models;

namespace Prueba2.Datos
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> opciones) : base(opciones)
        {
        }
        //Escribir modelos 
        public DbSet<Usuarios> Usuarios { get; set; }
        public DbSet<Sede> Sede { get; set; }

    }
}