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

        public IHttpActionResult Get()
        {
            return Ok(_repositoryPacientes.Selecionar());
        }

        // A interrogação (?) após o 'int' é usado pois a rota classifica o id como opcional,
        // a estrutura da controller precisa bater com a da rota (WebApiConfig)
        public IHttpActionResult Get(int? id)
        {
            if(!id.HasValue)
            {
                return BadRequest();
            }

            Paciente paciente = _repositoryPacientes.SelecionarPorID(id.Value);

            if(paciente == null)
            {
                return NotFound();
            }

            return Content(HttpStatusCode.Found, paciente);
        }

        public IHttpActionResult Post([FromBody]Paciente paciente)
        {
            try
            {
                _repositoryPacientes.Inserir(paciente);
                return Created($"{Request.RequestUri}/{paciente.Id}", paciente);
            }
            catch (System.Exception ex)
            {
                return InternalServerError(ex);
            }
        }
    }
}
