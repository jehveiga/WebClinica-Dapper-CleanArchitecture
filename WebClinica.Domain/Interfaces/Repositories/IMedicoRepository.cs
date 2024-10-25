using WebClinica.Domain.Entities;

namespace WebClinica.Domain.Interfaces.Repositories
{
    public interface IMedicoRepository
    {
        Task<IEnumerable<Medico>> GetMedicoAsync();
        Task<int> InsertMedicoAsync(Medico medico);
        Task<int> UpdateMedicoAsync(Medico medico, int crm);
        Task<int> DeleteMedicoAsync(int crm);
        Task<Medico?> GetMedicoByCrmAsync(int crm);
    }
}
