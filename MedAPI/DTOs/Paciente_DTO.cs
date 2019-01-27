using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MedAPI.DTOs
{
    public class Paciente_DTO : Usuario_DTO
    {
        public int ID { get; set; }
        public string Nome_Pai { get; set; }
        public string Nome_Mae { get; set; }
        public string Foto { get; set; }
        public IEnumerable<Endereco_DTO> Endereco { get; set; }
        public IEnumerable<Convenio_DTO> Convenio { get; set; }
    }
}
