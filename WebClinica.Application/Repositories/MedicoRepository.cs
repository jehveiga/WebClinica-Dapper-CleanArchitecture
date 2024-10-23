using Dapper;
using System.Data;
using WebClinica.Application.Dtos.InputModels;
using WebClinica.Domain.Entities;
using WebClinica.Domain.Interfaces.Repositories;
using WebClinica.Infrastructure.Factory;
using WebClinica.Infrastructure.Queries;

namespace WebClinica.Infrastructure.Repositories
{
    public class MedicoRepository(SqlFactory sqlFactory) : IMedicoRepository
    {
        private readonly IDbConnection _connection = sqlFactory.CreateConnection();

        public async Task<IEnumerable<Medico>> GetMedicoAsync()
        {
            QueryModel query = MedicosQueries.GetMedicoQuery();

            IEnumerable<Medico> medicos = await _connection.QueryAsync<Medico>(query.Query, query.Parameters);

            return medicos;
        }
        public async Task<Medico?> GetMedicoByCrmAsync(int crm)
        {
            QueryModel query = MedicosQueries.GetMedicoByCrmQuery(crm);

            Medico? medico = await _connection.QueryFirstOrDefaultAsync<Medico>(query.Query, query.Parameters);

            return medico;
        }
        public async Task<int> InsertMedicoAsync(Medico medico)
        {
            QueryModel query = MedicosQueries.InsertMedicoQuery(medico);

            CreatedMedicoViewModel? result = await _connection.QueryFirstOrDefaultAsync<CreatedMedicoViewModel>(query.Query, query.Parameters);

            return result!.crm;
        }
        public async Task<int> UpdateMedicoAsync(Medico medico, int crm)
        {
            QueryModel query = MedicosQueries.UpdateMedicoQuery(medico, crm);

            return await _connection.ExecuteAsync(query.Query, query.Parameters);
        }

        public async Task<int> DeleteMedicoAsync(int crm)
        {
            QueryModel query = MedicosQueries.DeleteMedicoQuery(crm);

            return await _connection.ExecuteAsync(query.Query, query.Parameters);
        }
    }
}
