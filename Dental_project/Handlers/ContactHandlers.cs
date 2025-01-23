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
        public async Task<List<Contact>> GetContactUs()
        {
            var data = await _repository.GetContactUs();
            if (data == null)
            {
                throw new Exception("no data found in the table Contact!!");
            }
            return data;
        }
    }
}
