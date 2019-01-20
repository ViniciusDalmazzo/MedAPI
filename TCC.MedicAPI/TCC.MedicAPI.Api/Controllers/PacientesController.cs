using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TCC.Common.Respositories.Interfaces;
using TCC.MedicAPI.Api.AutoMapper;
using TCC.MedicAPI.Api.DTOs;
using TCC.MedicAPI.Api.Filters;
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
            List<Paciente> pacientes = _repositoryPacientes.Selecionar();
            List<Paciente_DTO> dtos =
                AutoMapperManager.Instance.Mapper.Map<List<Paciente>, List<Paciente_DTO>>(pacientes);

            return Ok(dtos);
        }

        // A interrogação (?) após o 'int' é usado pois a rota classifica o id como opcional,
        // a estrutura da controller precisa bater com a da rota (WebApiConfig)
        public IHttpActionResult Get(int? id)
        {
            if (!id.HasValue)
            {
                return BadRequest();
            }

            Paciente paciente = _repositoryPacientes.SelecionarPorID(id.Value);

            if (paciente == null)
            {
                return NotFound();
            }

            Paciente_DTO dto = AutoMapperManager.Instance.Mapper.Map<Paciente, Paciente_DTO>(paciente);

            return Content(HttpStatusCode.Found, dto);
        }

        [ApplyModelValidation]
        public IHttpActionResult Post([FromBody]Paciente_DTO dto)
        {
            try
            {
                Paciente paciente = AutoMapperManager.Instance.Mapper.Map<Paciente_DTO, Paciente>(dto);
                _repositoryPacientes.Inserir(paciente);
                return Created($"{Request.RequestUri}/{paciente.ID}", paciente);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }

        }

        [ApplyModelValidation]
        public IHttpActionResult Put(int? id, [FromBody]Paciente_DTO dto)
        {
            try
            {
                if (!id.HasValue)
                {
                    return BadRequest();
                }

                Paciente paciente = AutoMapperManager.Instance.Mapper.Map<Paciente_DTO, Paciente>(dto);
                paciente.ID = id.Value;

                _repositoryPacientes.Atualizar(paciente);

                return Ok();
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        public IHttpActionResult Delete(int? id)
        {
            try
            {
                if (!id.HasValue)
                {
                    return BadRequest();
                }

                Paciente paciente = _repositoryPacientes.SelecionarPorID(id.Value);

                if (paciente == null)
                {
                    return NotFound();
                }

                _repositoryPacientes.ExcluirPorID(id.Value);
                return Ok();
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }
    }
}
