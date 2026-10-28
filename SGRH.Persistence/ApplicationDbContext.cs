using Microsoft.EntityFrameworkCore;
using SGRH.Domain;

namespace SGRH.Persistence
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Hotel> Hoteles { get; set; }
        public DbSet<Piso> Pisos { get; set; }
        public DbSet<Habitacion> Habitaciones { get; set; }
        public DbSet<Huesped> Huespedes { get; set; }
        public DbSet<Reserva> Reservas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configuración de precisión decimal para evitar advertencias de EF Core
            modelBuilder.Entity<Habitacion>()
                .Property(h => h.PrecioPorNoche)
                .HasColumnType("decimal(18,2)");

            modelBuilder.Entity<Reserva>()
                .Property(r => r.Total)
                .HasColumnType("decimal(18,2)");
        }
    }
}