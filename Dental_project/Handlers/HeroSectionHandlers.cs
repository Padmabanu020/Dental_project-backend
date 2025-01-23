
using Dental_project.Models;
using Dental_project.Repositories;



namespace Dental_project.Handlers
{
    public class HeroSectionHandlers
    {
        private readonly IRepository _repository;
        public HeroSectionHandlers(IRepository repository)
        {
            _repository = repository;
        }
        public async Task<List<HeroSection>> GetHeroSection()
        {
            var data = await _repository.GetHeroSection();

            if (data == null)
            {
                throw new Exception("no data found in the table Contact!!");
            }
            return data;
        }
    }
}
