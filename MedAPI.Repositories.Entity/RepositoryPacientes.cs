using Common.Repositories.Entity;
using MedAPI.Domain;
using MedAPI.Infra.Entity.Context;

namespace MedAPI.Repositories.Entity
{
    public class RepositoryPacientes : Repository<Paciente, int>
    {
        public RepositoryPacientes(MedAPIDBContext context)
            : base(context)
        {

        }
    }
}
