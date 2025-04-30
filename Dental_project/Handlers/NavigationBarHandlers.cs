using Dental_project.Models;
using Dental_project.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Dental_project.Handlers
{
    public class NavigationBarHandlers
    {
        private readonly IRepository _repository;
        public NavigationBarHandlers(IRepository repository)
        {
            _repository = repository;
        }
        public async Task<IActionResult> GetNavigationBar()
        {
            var data = await _repository.GetNavigationBar();

            if (data == null)
            {
                return new NoContentResult();
            }
            return new OkObjectResult(data);
        }
    }
}
