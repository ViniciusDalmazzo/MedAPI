using TCC.Common.Repositories.Entity;
using TCC.MedicAPI.Dominio.Entities;
using TCC.MEdicAPI.Infra.Entity.Context;

namespace TCC.MedicAPI.Repositories.Entity
{
    class RepositoryEnderecos : RepositoryTCC<Endereco, int>
    {
        public RepositoryEnderecos(MedicAPIDBContext context)
            : base(context)
        {
        }
    }
}
