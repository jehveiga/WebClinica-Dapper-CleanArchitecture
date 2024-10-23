using WebClinica.Domain.Entities;

namespace WebClinica.Domain.Interfaces.Repositories
{
    public interface IMedicoRepository
    {
        Task<IEnumerable<Medico>> GetMedicoAsync();
        Task<Medico> GetMedicoByIdAsync();
        Task<int> InsertMedicoAsync(Medico medico);
        Task<int> UpdateMedicoAsync(Medico medico, int id);
        Task<int> DeleteMedicoAsync(int id);
    }
}
