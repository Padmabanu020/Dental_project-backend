using Dental_project.Models;
using Dental_project.Repositories;

namespace Dental_project.Handlers
{
    public class IconHandlers
    {
        private readonly IRepository _repository;
        public IconHandlers(IRepository repository)
        {
            _repository = repository;
        }
        public async Task<List<Icon>> GetIcon()
        {
            var data = await _repository.GetIcon();

            if (data == null)
            {
                throw new Exception("no data found in the table Contact!!");
            }
            return data;
        }
    }
}
