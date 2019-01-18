using System.Collections.Generic;
using System.Web.Http;
using TCC.Common.Respositories.Interfaces;
using TCC.MedicAPI.Dominio;
using TCC.MedicAPI.Repositories.Entity;
using TCC.MEdicAPI.Infra.Entity.Context;

namespace TCC.MedicAPI.Api.Controllers
{
    public class PacientesController : ApiController
    {
        private IRepositoryTCC<Paciente, int> _repositoryPacientes
            = new RepositoryPacientes(new MedicAPIDBContext());

        public IEnumerable<Paciente> Get()
        {
            return _repositoryPacientes.Selecionar();
        }

        // A interrogação (?) após o 'int' é usado pois a rota classifica o id como opcional,
        // a estrutura da controller precisa bater com a da rota (WebApiConfig)
        public Paciente Get(int? id)
        {
            return _repositoryPacientes.SelecionarPorID(id.Value);
        }
    }
}
