using Common.Respositories.Interfaces;
using MedAPI.AutoMapper;
using MedAPI.Domain;
using MedAPI.DTOs;
using MedAPI.Infra.Entity.Context;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using MedAPI.Repositories.Entity;

namespace MedAPI.Controllers
{
    [Route("api/[controller]")]
    public class PacientesController : Controller
    {        
        private IRepository<Paciente, int> _repositoryPacientes
            = new RepositoryPacientes(new MedAPIDBContext());

        [HttpGet]
        public ActionResult Get()
        {
            List<Paciente> pacientes = _repositoryPacientes.Selecionar();
            List<Paciente_DTO> dtos =
                AutoMapperManager.Instance.Mapper.Map<List<Paciente>, List<Paciente_DTO>>(pacientes);

            return Ok(dtos);
        }

        // A interrogação (?) após o 'int' é usado pois a rota classifica o id como opcional,
        // a estrutura da controller precisa bater com a da rota (WebApiConfig)
        [HttpGet("pacientes/{id}")]
        public ActionResult Get(int? id)
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

            return Ok(dto);
        }
        
        [HttpPost]
        public ActionResult Post([FromBody]Paciente_DTO dto)
        {
            try
            {
                Paciente paciente = AutoMapperManager.Instance.Mapper.Map<Paciente_DTO, Paciente>(dto);
                _repositoryPacientes.Inserir(paciente);
                //return Created($"{Request.RequestUri}/{paciente.ID}", paciente);
                return Ok();
            }
            catch (Exception ex)
            {
                return NotFound(ex);
            }

        }
        
        public ActionResult Put(int? id, [FromBody]Paciente_DTO dto)
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
                return NotFound(ex);
            }
        }
        

        public ActionResult Delete(int? id)
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
                return NotFound(ex);
            }
        }
    }
}
