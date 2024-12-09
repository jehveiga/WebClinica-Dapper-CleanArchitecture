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
                    [NOME] AS Nome,
                    [CRM] AS Crm,
                    [Especialidade] AS Especialidade,
                    [Telefone] AS Telefone,
                    [Email] AS Email,
                    [DataCadastro] AS DataCadastro
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
                    [NOME] AS Nome,
                    [CRM] AS Crm,
                    [Especialidade] AS Especialidade,
                    [Telefone] AS Telefone,
                    [Email] AS Email,
                    [DataCadastro] AS DataCadastro
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
                INSERT INTO {table}
                    ([Nome],
                    [CRM],
                    [Especialidade],
                    [Telefone],
                    [Email],
                    [DataCadastro])
                OUTPUT
                    Inserted.CRM
                VALUES
                    (
                        @Nome,
                        @Crm,
                        @Especialidade,
                        @Telefone,
                        @Email,
                        @DataCadastro
                    );
            ";

            var parameters = new
            {
                medico.Nome,
                medico.Crm,
                medico.Especialidade,
                medico.Telefone,
                medico.Email,
                medico.DataCadastro
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
                    [Especialidade] = @Especialidade,
                    [Telefone] = @Telefone,
                    [Email] = @Email
                WHERE
                    [CRM] = @Crm
                ;
            ";

            var parameters = new
            {
                Crm = crm,
                medico.Nome,
                medico.Especialidade,
                medico.Telefone,
                medico.Email
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