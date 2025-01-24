using Dapper;
using System.Data;
using System.Data.Common;
using Dental_project.Handlers;
using Dental_project.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections;


namespace Dental_project.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class apiController : ControllerBase
    {
        private readonly ContactHandlers _ContactHandler;
        private readonly HeroSectionHandlers _HeroSectionHandlers;
        private readonly NavigationBarHandlers _NavigationBarHandlers;
        private readonly IconHandlers _IconHandlers;

        public apiController(ContactHandlers ContactHandler,HeroSectionHandlers HeroSectionHandlers, NavigationBarHandlers NavigationBarHandlers, IconHandlers IconHandlers)
        {
            _ContactHandler = ContactHandler;
            _HeroSectionHandlers = HeroSectionHandlers;
            _NavigationBarHandlers = NavigationBarHandlers;
            _IconHandlers = IconHandlers;
        }



        [HttpGet("ContactDetails")]
        [ProducesResponseType(typeof(Contact), 200)]
        [ProducesResponseType(404)]
        [ProducesResponseType(500)]
        public async Task<IActionResult> GetContactUs()
        {
           
            var data = await _ContactHandler.GetContactUs();
            if (data == null)
            {
                return NotFound("Data not found");
            }

            return Ok(data);
        }

        [HttpGet("HeroSection")]
        [ProducesResponseType(typeof(HeroSection),200)]
        [ProducesResponseType(404)]
        [ProducesResponseType(500)]
        public async Task<IActionResult> GetHeroSections()
        {
            var data = await _HeroSectionHandlers.GetHeroSection();
            if (data == null)
            {
                return NotFound("Data not found");
            }
            return Ok(data);

        }
        [HttpGet("NavigationBar")]
        [ProducesResponseType(typeof(Icon),200)]
        [ProducesResponseType(404)]
        [ProducesResponseType(500)]
        public async Task<IActionResult> GetNavigationBar() 
        {
            var data = await _NavigationBarHandlers.GetNavigationBar();
            if (data == null)
            {
                return NotFound("Data not found");
            }
            return Ok(data);

        }
        [HttpGet("Icon")]
        [ProducesResponseType(typeof(NavigationBar),200)]
        [ProducesResponseType(404)]
        [ProducesResponseType(500)]
        public async Task<IActionResult> GetIcon()
        {
            var data = await _IconHandlers.GetIcon();
            if (data == null)
            {
                return NotFound("Data not found");
            }
            return Ok(data);

        }
    }
}