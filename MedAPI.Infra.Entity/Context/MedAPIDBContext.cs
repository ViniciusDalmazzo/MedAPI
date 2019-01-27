using MedAPI.Domain;
using Microsoft.EntityFrameworkCore;

namespace MedAPI.Infra.Entity.Context
{
    public class MedAPIDBContext : DbContext
    {
        public DbSet<Paciente> Pacientes { get; private set; }
        public DbSet<Endereco> Enderecos { get; private set; }
        public DbSet<Funcionario> Funcionarios { get; private set; }
        public DbSet<Medico> Medicos { get; private set; }
        public DbSet<Consulta> Consultas { get; private set; }
        public DbSet<Convenio> Convenios { get; private set; }
                
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        { 
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-GVK3AVD\SQLEXPRESS;DataBase=MedicAPI;User Id=vine;Password=123;");            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
        }

    }
}
