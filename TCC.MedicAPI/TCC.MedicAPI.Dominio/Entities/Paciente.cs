using System.Collections.Generic;
using TCC.MedicAPI.Dominio.Entities;

namespace TCC.MedicAPI.Dominio
{
    public class Paciente
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string RG { get; set; }
        public string CPF { get; set; }
        public ICollection<Endereco> Endereco { get; set; }
    }
}
