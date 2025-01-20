using System.Data;
using System.Data.Common;
using Dapper;
using Dental_project.DatabaseConnection;
using Dental_project.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using DbConnection = Dental_project.DatabaseConnection.DbConnection;
namespace Dental_project.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ContactController : ControllerBase
    {
        private readonly DbConnection _dbConnection;

        public ContactController(DbConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }

        [HttpGet]
        public async Task<ActionResult<List<Contact>>> GetContactUs()
        {
            try
            {
                using (var conn = _dbConnection.GetSqlConnection())
                {
                    var contactList = await conn.QueryAsync<Contact>("GetContact", new { }, commandType: CommandType.StoredProcedure);
                    return contactList.ToList();
                }
                    
            }
            catch(Exception ex)
            {
                throw new Exception("Error Fetching Contact", ex);
            }
        }
        
    }
}