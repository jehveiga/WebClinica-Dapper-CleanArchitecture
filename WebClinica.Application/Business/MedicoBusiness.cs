using WebClinica.Api.Mappings;
using WebClinica.Application.Dtos.InputModels;
using WebClinica.Application.Dtos.ViewModels;
using WebClinica.Domain.Entities;
using WebClinica.Domain.Interfaces.Repositories;

namespace WebClinica.Application.Business
{
    public class MedicoBusiness(IMedicoRepository medicoRepository) : IMedicoBusiness
    {
        public async Task<IEnumerable<MedicoViewModel>> Obter()
        {
            IEnumerable<Medico> medicosDb = await medicoRepository.GetMedicoAsync();

            IEnumerable<MedicoViewModel> medicosDto = medicosDb.ConverteMedicoParaDto();

            return medicosDto;
        }
        public async Task<MedicoViewModel> ObterPeloCrm(int crm)
        {
            Medico? medicoDb = await medicoRepository.GetMedicoByCrmAsync(crm);

            MedicoViewModel? medicoViewModel = MedicoViewModel.FromEntity(medicoDb);

            return medicoViewModel!;

        }
        public Task Adicionar(CreateMedicoInputModel createMedicoInput)
        {
            throw new NotImplementedException();
        }

        public Task Alterar(int crm, UpdateMedicoInputModel updateMedicoInput)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int crm)
        {
            throw new NotImplementedException();
        }


    }
}
