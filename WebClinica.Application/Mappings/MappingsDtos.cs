using WebClinica.Application.Dtos.ViewModels;
using WebClinica.Domain.Entities;

namespace WebClinica.Api.Mappings
{
    public static class MappingsDtos
    {
        public static IEnumerable<MedicoViewModel> ConverteMedicoParaDto(this IEnumerable<Medico> medicos)
        {
            List<MedicoViewModel> medicoDto = (from medico in medicos
                                               select new MedicoViewModel(
                                                   medico.Crm,
                                                   medico.Nome,
                                                   medico.Sexo,
                                                   medico.DataNascimento.ToShortDateString(),
                                                   medico.EspecialidadeId
                                                   )).ToList();

            return medicoDto;
        }
    }
}
