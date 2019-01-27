using Common.Repositories.Entity;
using MedAPI.Domain;
using MedAPI.Infra.Entity.Context;

namespace MedAPI.Repositories.Entity
{
    public class RepositoryConsultas : Repository<Consulta, int>
    {
        public RepositoryConsultas(MedAPIDBContext context)
            : base(context)
        {

        }
    }
}
