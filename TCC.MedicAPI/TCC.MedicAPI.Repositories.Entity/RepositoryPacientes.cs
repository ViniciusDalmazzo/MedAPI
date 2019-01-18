using TCC.Common.Repositories.Entity;
using TCC.MedicAPI.Dominio;
using TCC.MEdicAPI.Infra.Entity.Context;

namespace TCC.MedicAPI.Repositories.Entity
{
    public class RepositoryPacientes : RepositoryTCC<Paciente, int>
    {
        public RepositoryPacientes(MedicAPIDBContext context)
            : base(context)
        {

            
        }
    }
}
