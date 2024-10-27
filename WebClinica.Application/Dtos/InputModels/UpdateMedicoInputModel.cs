using System.ComponentModel.DataAnnotations;
using WebClinica.Domain.Entities;

namespace WebClinica.Application.Dtos.InputModels
{
    public record UpdateMedicoInputModel(
        [Required] string Nome,
        [Required]
        [AllowedValues('M', 'F', ErrorMessage = "Valor nãO permitido para o campo sexo, usar 'M' ou 'F'")] char Sexo,
        [Required] DateTime DataNascimento,
        [Required] int EspecialidadeId)
    {
        public Medico ToEntity()
        {
            return new Medico(Nome, Sexo, DataNascimento, EspecialidadeId);
        }
    }
}
