using System.ComponentModel.DataAnnotations;
using WebClinica.Domain.Entities;

namespace WebClinica.Application.Dtos.InputModels
{
    public record CreateMedicoInputModel(
        [Required]
        [Range(100000, 999999)] int Crm,
        [Required] string Nome,
        [Required]
        [AllowedValues('M', 'F') ] char Sexo,
        [Required] DateTime DataNascimento,
        [Required] int EspecialidadeId)
    {
        public Medico ToEntity()
        {
            return new Medico(Crm, Nome, Sexo, DataNascimento, EspecialidadeId);
        }
    }
}
