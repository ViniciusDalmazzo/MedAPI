using TCC.MedicAPI.Dominio;

namespace TCC.MedicAPI.Api.DTOs
{
    public class Endereco_DTO
    {
        public int ID { get; set; }
        public string Rua { get; set; }
        public string Bairro { get; set; }
        public string Pais { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string CEP { get; set; }
        public int Numero { get; set; }
        public string Complemento { get; set; }
        public Paciente Paciente { get; set; }
    }
}