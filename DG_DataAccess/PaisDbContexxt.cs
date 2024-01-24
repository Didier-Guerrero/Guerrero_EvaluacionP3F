using Foundation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Guerrero_EvaluacionP3F.DG_DataAccess
{
    public class PaisDbContexxt
    {
        public class ReservaDbContext : DbContext
        {
            public DbSet<Reserva> Reservas { get; set; }
            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                string conexionDB = $"Filename={ConexionDB.DevolverRuta("reservas.db")}";
                optionsBuilder.UseSqlite(conexionDB);
            }
            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                modelBuilder.Entity<Reserva>(entity =>
                {
                    entity.HasKey(col => col.IdReserva);
                    entity.Property(col => col.IdReserva).IsRequired().ValueGeneratedOnAdd();
                });
            }
        }
    }
}
