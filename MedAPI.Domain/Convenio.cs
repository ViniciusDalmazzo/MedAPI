using System;

namespace MedAPI.Domain
{
    public class Convenio
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public DateTime Inicio { get; set; }
        public int PacienteId { get; set; }
        public Paciente Paciente { get; set; }
    }
}
