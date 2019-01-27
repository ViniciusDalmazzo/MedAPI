using Common.Repositories.Entity;
using MedAPI.Domain;
using MedAPI.Infra.Entity.Context;

namespace MedAPI.Repositories.Entity
{
    public class RepositoryConvenios : Repository<Convenio, int>
    {
        public RepositoryConvenios(MedAPIDBContext context)
            : base(context)
        {

        }
    }
}
