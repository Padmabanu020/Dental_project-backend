using Microsoft.Data.SqlClient;

namespace Dental_project.DataBase

{
    public class DataBaseConnection
    {
        private readonly IConfiguration _configuration;
        public string ConnectionString { get; }
        public DataBaseConnection(IConfiguration configuration)
        {
            _configuration = configuration;
            ConnectionString = _configuration.GetConnectionString("DefaultConnection");
        }
    }
}