using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TCC.MedicAPI.Api.DTOs;
using TCC.MedicAPI.Dominio;

namespace TCC.MedicAPI.Api.AutoMapper
{
    public class AutoMapperManager
    {
        private static readonly Lazy<AutoMapperManager> _instance
            = new Lazy<AutoMapperManager>(() =>
            {
                return new AutoMapperManager();
            });

        public static AutoMapperManager Instance
        {
            get
            {
                return _instance.Value;
            }
        }

        private MapperConfiguration _config;

        public IMapper Mapper
        {
            get
            {
                return _config.CreateMapper();
            }
        }

        private AutoMapperManager()
        {
            _config = new MapperConfiguration((cfg) =>
            {

                cfg.CreateMap<Paciente, Paciente_DTO>();
                cfg.CreateMap<Paciente_DTO, Paciente>();
            });
        }
    }
}