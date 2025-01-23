using Dental_project.Models;
using Microsoft.AspNetCore.Mvc;

namespace Dental_project.Repositories
{
    public interface IRepository
    {
        Task<List<Contact>> GetContactUs();
        Task<List<HeroSection>> GetHeroSection();
        Task<List<NavigationBar>> GetNavigationBar();
        Task<List<Icon>> GetIcon();
    }

}
