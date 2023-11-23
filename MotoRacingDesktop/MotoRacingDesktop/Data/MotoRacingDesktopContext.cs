using Microsoft.EntityFrameworkCore;
using MotoRacingDesktop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace MotoRacingDesktop.Data
{
    public class MotoRacingDesktopContext : DbContext
    {
        public DbSet<Corredor> Corredores { get; set; }
        public DbSet<Actividad> Actividades { get; set; }
        public DbSet<Cobrador> Cobradores { get; set; }
        public DbSet<Cuota> Cuotas { get; set; }
        public DbSet<Vehiculo> Vehiculos { get; set; }
        public DbSet<Pista> Pistas { get; set; }

        public MotoRacingDesktopContext()
        {
            
        }
        public MotoRacingDesktopContext(DbContextOptions<MotoRacingDesktopContext> options) : base(options)
        {
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string cadenaConexion = "Server=.\\SQLEXPRESS ; User Id=sa ; Password=123 ; Database=MotoRacingDesktopContext ; MultipleActiveResultSets=True ; Encrypt=False ";
            optionsBuilder.UseSqlServer(cadenaConexion);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Actividad>().HasData(
                new Actividad { Id = 1, Nombre = "Moto GP", Costo = 25000, Horarios = "Lunes y miércoles 20hs" },
                new Actividad { Id = 2, Nombre = "Moto Cross", Costo = 25000, Horarios = "Martes y Jueves 20hs" },
                new Actividad { Id = 3, Nombre = "Karting GP", Costo = 20000, Horarios = "Lunes y miércoles 16hs" },
                new Actividad { Id = 4, Nombre = "Moto Enduro", Costo = 20000, Horarios = "Martes y Jueves 16hs" }
                );

            modelBuilder.Entity<Actividad>()
            .HasOne(a => a.Corredores)
            .WithOne(c => c.Actividad)
            .HasForeignKey<Corredor>(c => c.ActividadId);

            modelBuilder.Entity<Cobrador>().HasData(
                new Cobrador { Id = 1, Nombre = "Rodrigo Palacio" }
                );
        }
    }
}
