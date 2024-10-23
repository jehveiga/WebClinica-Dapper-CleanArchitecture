using WebClinica.Domain.Entities;
using WebClinica.Domain.Interfaces.Repositories;

namespace WebClinica.Infrastructure.Repositories
{
    public class MedicoRepository : IMedicoRepository
    {
        public Task<int> DeleteMedicoAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Medico>> GetMedicoAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Medico> GetMedicoByIdAsync()
        {
            throw new NotImplementedException();
        }

        public Task<int> InsertMedicoAsync(Medico medico)
        {
            throw new NotImplementedException();
        }

        public Task<int> UpdateMedicoAsync(Medico medico, int id)
        {
            throw new NotImplementedException();
        }
    }
}
