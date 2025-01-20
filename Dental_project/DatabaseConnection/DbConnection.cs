using Microsoft.Data.SqlClient;

namespace Dental_project.DatabaseConnection
{
    public class DbConnection
    {
        private readonly IConfiguration configuration;
        private readonly string _connectionString;
        public DbConnection(IConfiguration configuration)
        { 
            this.configuration = configuration;
            _connectionString = configuration.GetConnectionString("Database");
        }
        public SqlConnection GetSqlConnection()
        {
            return new SqlConnection(_connectionString);
        }
    }
} 