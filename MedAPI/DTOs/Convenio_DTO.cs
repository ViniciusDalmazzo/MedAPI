using MedAPI.Domain;
using System;

namespace MedAPI.DTOs
{
    public class Convenio_DTO
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public string Inicio { get; set; }
        public Paciente Paciente { get; set; }
    }
}
