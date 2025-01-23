using Dental_project.Models;
using Dental_project.Repositories;

namespace Dental_project.Handlers
{
    public class NavigationBarHandlers
    {
        private readonly IRepository _repository;
        public NavigationBarHandlers(IRepository repository)
        {
            _repository = repository;
        }
        public async Task<List<NavigationBar>> GetNavigationBar()
        {
            var data = await _repository.GetNavigationBar();

            if (data == null)
            {
                throw new Exception("no data found in the table Contact!!");
            }
            return data;
        }
    }
}
