using Dental_project.Models;
using Dental_project.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Dental_project.Handlers
{
    public class IconHandlers
    {
        private readonly IRepository _repository;
        public IconHandlers(IRepository repository)
        {
            _repository = repository;
        }
        public async Task<IActionResult> GetIcon()
        {
            var data = await _repository.GetIcon();
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                
            if (data == null)
            {
                return new NoContentResult();
            }
            return new OkObjectResult(data);
        }
    }
}
