using System.Data;
using Dapper;
using Dental_project.DatabaseConnection;
using Dental_project.Models;
using Microsoft.AspNetCore.Mvc;

namespace Dental_project.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HeroSectionController : ControllerBase
    {
        private readonly DbConnection _dbConnection;

        public HeroSectionController(DbConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }

        [HttpGet]
        public async Task<ActionResult<List<HeroSection>>> GetHeroSections()
        {
            try
            {
                using (var conn = _dbConnection.GetSqlConnection())
                {
                    var heroSections = await conn.QueryAsync<HeroSection>(
                        "GetHeroSections",
                        commandType: CommandType.StoredProcedure
                    );
                    return Ok(heroSections.ToList());
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = "Error Fetching Hero Sections", details = ex.Message });
            }
        }
    }
}
