using Dapper;
using Dental_project.Models;
using Dental_project.Repositories;
using Microsoft.AspNetCore.Mvc;


namespace Dental_project.Handlers
{
    public class ContactHandlers
    {
        private readonly IRepository _repository;
        public ContactHandlers(IRepository repository)
        {
            _repository = repository; 
        }
        public async Task<IActionResult> GetContactUs()
        {
            var data = await _repository.GetContactUs();
            if (data == null)
            {
                return new NoContentResult();
            }
            return new OkObjectResult(data);
        }
    }
}
