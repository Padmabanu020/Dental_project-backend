using System.Data;
using Dapper;
using Dental_project.DatabaseConnection;
using Dental_project.Models;
using Microsoft.AspNetCore.Mvc;

namespace Dental_project.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class NavigationBarController : ControllerBase
    {
        private readonly DbConnection _dbConnection;

        public NavigationBarController(DbConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }

        [HttpGet]
        public async Task<ActionResult<List<NavigationBar>>> GetNavigationBar()
        {
            try
            {
                using (var conn = _dbConnection.GetSqlConnection())
                {
                    var navigationList = await conn.QueryAsync<NavigationBar>(
                        "GetNavigationBar",
                        commandType: CommandType.StoredProcedure
                    );
                    return Ok(navigationList.ToList());
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = "Error Fetching Navigation Bar", details = ex.Message });
            }
        }
    }
}
