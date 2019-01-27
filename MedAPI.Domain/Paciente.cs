using System.Collections.Generic;

namespace MedAPI.Domain
{
    public class Paciente : Usuario
    {
        public int ID { get; set; }        
        public string Nome_Pai { get; set; }
        public string Nome_Mae { get; set; }        
        public string Foto { get; set; }
        public ICollection<Endereco> Endereco { get; set; }
        public ICollection<Consulta> Consulta { get; set; }
        public ICollection<Convenio> Convenio { get; set; }
    }
}
