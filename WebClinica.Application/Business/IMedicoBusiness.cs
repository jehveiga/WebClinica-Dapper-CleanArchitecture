using WebClinica.Application.Dtos.InputModels;
using WebClinica.Application.Dtos.ViewModels;

namespace WebClinica.Application.Business
{
    public interface IMedicoBusiness
    {
        public Task<IEnumerable<MedicoViewModel>> Obter();
        public Task<MedicoViewModel> ObterPeloCrm(int crm);
        public Task<CreatedMedicoViewModel> Adicionar(CreateMedicoInputModel createMedicoInput);
        public Task<int> Alterar(int crm, UpdateMedicoInputModel updateMedicoInput);
        public Task<int> Delete(int crm);
    }
}
