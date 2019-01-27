using System.Collections.Generic;

namespace MedAPI.Domain
{
    public class Medico : Usuario
    {
        public int ID { get; set; }
        public string Especialidade { get; set; }
        public string Area { get; set; }
        public ICollection<Consulta> Consulta { get; set; }
    }
}
