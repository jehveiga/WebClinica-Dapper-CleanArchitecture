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

            MedicoViewModel? medicoViewModel = MedicoViewModel.FromEntity(medicoDb!);

            return medicoViewModel!;

        }
        public async Task<CreatedMedicoViewModel> Adicionar(CreateMedicoInputModel createMedicoInput)
        {
            Medico medico = createMedicoInput.ToEntity();

            int createdMedicoView = await medicoRepository.InsertMedicoAsync(medico);

            return new CreatedMedicoViewModel(createdMedicoView);
        }

        public async Task<int> Alterar(int crm, UpdateMedicoInputModel updateMedicoInput)
        {
            Medico medico = updateMedicoInput.ToEntity();

            int result = await medicoRepository.UpdateMedicoAsync(medico, crm);

            return result;
        }

        public Task<int> Delete(int crm)
        {
            throw new NotImplementedException();
        }


    }
}
