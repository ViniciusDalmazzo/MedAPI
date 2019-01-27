using Common.Repositories.Entity;
using MedAPI.Domain;
using MedAPI.Infra.Entity.Context;

namespace MedAPI.Repositories.Entity
{
    public class RepositoryEnderecos : Repository<Endereco, int>
    {
        public RepositoryEnderecos(MedAPIDBContext context)
            : base(context)
        {
        }
    }
}
