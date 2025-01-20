using System.Data;
using Dapper;
using Dental_project.DatabaseConnection;
using Dental_project.Models;
using Microsoft.AspNetCore.Mvc;

namespace Dental_project.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class IconController : ControllerBase
    {
        private readonly DbConnection _dbConnection;

        public IconController(DbConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }

        [HttpGet]
        public async Task<ActionResult<List<Icon>>> GetIcons()
        {
            try
            {
                using (var conn = _dbConnection.GetSqlConnection())
                {
                    var icons = await conn.QueryAsync<Icon>(
                        "GetIcons",
                        commandType: CommandType.StoredProcedure
                    );
                    return Ok(icons.ToList());
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = "Error Fetching Icons", details = ex.Message });
            }
        }
    }
}
