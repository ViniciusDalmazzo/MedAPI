using System.Data.Entity;
using System.Collections.Generic;
using TCC.MedicAPI.Dominio;
using TCC.MedicAPI.Dominio.Entities;

namespace TCC.MEdicAPI.Infra.Entity.Context
{
    public class MedicAPIDBContext : DbContext
    {
        public DbSet<Paciente> Pacientes { get; private set; }
        public DbSet<Endereco> Enderecos { get; private set; }

        public MedicAPIDBContext()
        {
            Configuration.ProxyCreationEnabled = false;
            Configuration.LazyLoadingEnabled = false;
        }

        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Endereco>()
        //        .HasRequired<Paciente>(s => s.Paciente)
        //        .WithMany(g => g.Endereco)
        //        .HasForeignKey<int>(s => s.CurrentGradeId);
        //}

    }
}
