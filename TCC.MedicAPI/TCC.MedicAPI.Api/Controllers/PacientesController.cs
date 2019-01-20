using System.Collections.Generic;
using System.Net;
using System.Net.Http;
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
        public HttpResponseMessage Get(int? id)
        {
            if(!id.HasValue)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }

            Paciente paciente = _repositoryPacientes.SelecionarPorID(id.Value);

            if(paciente == null)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound);
            }

            return Request.CreateResponse(HttpStatusCode.Found, paciente);
        }

        public HttpResponseMessage Post([FromBody]Paciente paciente)
        {
            try
            {
                _repositoryPacientes.Inserir(paciente);
                return Request.CreateResponse(HttpStatusCode.Created);
            }
            catch (System.Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
    }
}
