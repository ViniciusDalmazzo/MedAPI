using Common.Repositories.Entity;
using MedAPI.Domain;
using MedAPI.Infra.Entity.Context;

namespace MedAPI.Repositories.Entity
{
    public class RepositoryMedicos : Repository<Medico, int>
    {
        public RepositoryMedicos(MedAPIDBContext context)
            : base(context)
        {

        }
    }
}
