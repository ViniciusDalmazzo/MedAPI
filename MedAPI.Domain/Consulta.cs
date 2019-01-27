using System;

namespace MedAPI.Domain
{
    public class Consulta
    {
        public int ID { get; set; }
        public DateTime Data { get; set; }
        public int PacienteId { get; set; }
        public Paciente Paciente { get; set; }
        public Medico Medico { get; set; }
    }
}
