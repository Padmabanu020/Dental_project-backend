
using Dental_project.Models;
using Dental_project.Repositories;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;



namespace Dental_project.Handlers
{
    public class HeroSectionHandlers
    {
        private readonly IRepository _repository;
        public HeroSectionHandlers(IRepository repository)
        {
            _repository = repository;
        }
        public async Task<IActionResult> GetHeroSection()
        {
            var data = await _repository.GetHeroSection();

            if (data == null )
            {
                return new NoContentResult();
            }
            return  new OkObjectResult(data);
        }
    }
}
