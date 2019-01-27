using Common.Repositories.Entity;
using MedAPI.Domain;
using MedAPI.Infra.Entity.Context;

namespace MedAPI.Repositories.Entity
{
    class RepositoryFuncionarios : Repository<Funcionario, int>
    {
        public RepositoryFuncionarios(MedAPIDBContext context)
           : base(context)
        {
            
        }
    }
}
