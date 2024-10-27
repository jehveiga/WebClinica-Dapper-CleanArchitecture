using WebClinica.Domain.Entities;

namespace WebClinica.Application.Dtos.ViewModels
{
    public record MedicoViewModel(int Crm, string Nome, char Sexo, string DataNascimento, int EspecialidadeId)
    {
        public static MedicoViewModel? FromEntity(Medico medico)
        {
            if (medico is null)
                return default;

            return new MedicoViewModel(
                medico.Crm,
                medico.Nome,
                medico.Sexo,
                medico.DataNascimento.ToShortDateString(),
                medico.EspecialidadeId
                );
        }
    }
}
