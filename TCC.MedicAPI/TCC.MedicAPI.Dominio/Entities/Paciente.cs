using System;

namespace TCC.MedicAPI.Dominio
{
    public class Paciente
    {
        public int ID { get; private set; }
        public string Nome { get; private set; }
        public string Sobrenome { get; private set; }
        public DateTime DataDeNascimento { get; private set; }
    }
}
