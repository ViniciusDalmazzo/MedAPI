using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TCC.MedicAPI.Api.DTOs
{
    public class Paciente_DTO
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "O nome do paciente é obrigatório.")]
        [StringLength(maximumLength: 20, MinimumLength = 2, ErrorMessage = "O nome do paciente deve possuir no minímo 2 e no máximo 20 caracteres.")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "O sobrenome do paciente é obrigatório.")]
        [StringLength(maximumLength: 50, MinimumLength = 2, ErrorMessage = "O sobrenome do paciente deve possuir no minímo 2 e no máximo 50 caracteres.")]
        public string Sobrenome { get; set; }
        [Required(ErrorMessage = "O RG do paciente é obrigatório.")]
        [StringLength(maximumLength: 14, MinimumLength = 11, ErrorMessage = "O RG do paciente deve possuir no minímo 11 e no máximo 14 caracteres.")]
        public string RG { get; set; }
        [Required(ErrorMessage = "O CPF do paciente é obrigatório.")]
        [StringLength(maximumLength: 14, MinimumLength = 11, ErrorMessage = "O CPF do paciente deve possuir 11 caracteres.")]
        public string CPF { get; set; }
        public IEnumerable<Endereco_DTO> Endereco { get; set; }
    }
}