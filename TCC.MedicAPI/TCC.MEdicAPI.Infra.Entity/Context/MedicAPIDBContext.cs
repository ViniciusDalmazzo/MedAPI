using System.Data.Entity;
using TCC.MedicAPI.Dominio;

namespace TCC.MEdicAPI.Infra.Entity.Context
{
    public class MedicAPIDBContext : DbContext
    {
        public DbSet<Paciente> Pacientes { get; private set; }

        public MedicAPIDBContext()
        {
            Configuration.ProxyCreationEnabled = false;
            Configuration.LazyLoadingEnabled = false;

        }
    }
}
