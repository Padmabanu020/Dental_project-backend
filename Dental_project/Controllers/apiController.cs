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
        [ProducesResponseType(200)]
        [ProducesResponseType(404)]
        [ProducesResponseType(500)]
        public async Task<IActionResult> GetContactUs()
        {
            Console.WriteLine("testing1");
            var data = await _ContactHandler.GetContactUs();
            Console.WriteLine("testing");
            return Ok(data);
        }

        [HttpGet("HeroSection")]
        [ProducesResponseType(200)]
        [ProducesResponseType(404)]
        [ProducesResponseType(500)]
        public async Task<IActionResult> GetHeroSections()
        {
            var data = await _HeroSectionHandlers.GetHeroSection();
            return Ok(data);

        }
        [HttpGet("NavigationBar")]
        [ProducesResponseType(200)]
        [ProducesResponseType(404)]
        [ProducesResponseType(500)]
        public async Task<IActionResult> GetNavigationBar()
        {
            var data = await _NavigationBarHandlers.GetNavigationBar();
            return Ok(data);

        }
        [HttpGet("Icon")]
        [ProducesResponseType(200)]
        [ProducesResponseType(404)]
        [ProducesResponseType(500)]
        public async Task<IActionResult> GetIcon()
        {
            var data = await _IconHandlers.GetIcon();
            return Ok(data);

        }
    }
}