using WebClinica.Domain.Entities;
using WebClinica.Infrastructure.Map;

namespace WebClinica.Infrastructure.Queries
{
    public static class MedicosQueries
    {
        public static QueryModel GetMedicoQuery()
        {
            string table = ContextMapping.MedicoTable;
            string query = @$"
                SELECT 
                    [CRM] AS Crm, 
                    [NOME] AS Nome, 
                    [SEXO] AS Sexo, 
                    [DATA_NASCIMENTO] AS DataNascimento, 
                    [ID_ESP] AS EspecialidadeId
                FROM 
                    {table}; 
            ";

            var parameters = new { };

            return new QueryModel(query, parameters);
        }

        public static QueryModel GetMedicoByCrmQuery(int crm)
        {
            string table = ContextMapping.MedicoTable;
            string query = @$"
                SELECT 
                    [CRM] AS Crm, 
                    [NOME] AS Nome, 
                    [SEXO] AS Sexo, 
                    [DATA_NASCIMENTO] AS DataNascimento, 
                    [ID_ESP] AS EspecialidadeId
                FROM 
                    {table}
                WHERE
                    [CRM] = @Crm; 
            ";

            var parameters = new
            {
                Crm = crm
            };

            return new QueryModel(query, parameters);
        }

        public static QueryModel InsertMedicoQuery(Medico medico)
        {
            string table = ContextMapping.MedicoTable;
            string query = @$"
                INSERT INTO 
                    {table}
                    ([CRM], 
                    [NOME], 
                    [SEXO], 
                    [DATA_NASCIMENTO], 
                    [ID_ESP])
                VALUES
                    (
                        @Crm,
                        @Nome,
                        @Sexo,
                        @DataNascimento,
                        @EspecialidadeId
                    );
            ";

            var parameters = new
            {
                medico.Crm,
                medico.Nome,
                medico.Sexo,
                medico.DataNascimento,
                medico.EspecialidadeId
            };

            return new QueryModel(query, parameters);
        }

        public static QueryModel UpdateMedicoQuery(Medico medico, int crm)
        {
            string table = ContextMapping.MedicoTable;
            string query = @$"
                UPDATE 
                    {table}
                SET
                    [NOME] = @Nome, 
                    [SEXO] = @Sexo, 
                    [DATA_NASCIMENTO] = @DataNascimento, 
                    [ID_ESP] = @EspecialidadeId
                WHERE
                    [CRM] = @Crm
                ;
            ";

            var parameters = new
            {
                medico.Crm,
                medico.Nome,
                medico.Sexo,
                medico.DataNascimento,
                medico.EspecialidadeId
            };

            return new QueryModel(query, parameters);
        }

        public static QueryModel DeleteMedicoQuery(int crm)
        {
            string table = ContextMapping.MedicoTable;
            string query = @$"
                DELETE FROM 
                    {table}
                WHERE
                    [CRM] = @Crm
                ;
            ";

            var parameters = new
            {
                Crm = crm
            };

            return new QueryModel(query, parameters);
        }
    }
}
