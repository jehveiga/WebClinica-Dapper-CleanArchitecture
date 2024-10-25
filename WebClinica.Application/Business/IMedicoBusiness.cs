using WebClinica.Application.Dtos.InputModels;
using WebClinica.Application.Dtos.ViewModels;

namespace WebClinica.Application.Business
{
    public interface IMedicoBusiness
    {
        public Task<IEnumerable<MedicoViewModel>> Obter();
        public Task<MedicoViewModel> ObterPeloCrm(int crm);
        public Task Adicionar(CreateMedicoInputModel createMedicoInput);
        public Task Alterar(int crm, UpdateMedicoInputModel updateMedicoInput);
        public Task Delete(int crm);
    }
}
