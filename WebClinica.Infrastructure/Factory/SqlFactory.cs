using Microsoft.Extensions.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace WebClinica.Infrastructure.Factory
{
    public class SqlFactory(IConfiguration configuration)
    {
        public IDbConnection CreateConnection()
        {
            string connectionString = configuration.GetConnectionString("DefaultConnection")!;
            return new SqlConnection(connectionString);
        }
    }
}
