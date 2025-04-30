using Dental_project.Models;
using Dapper;
using Dental_project.DataBase;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;

namespace Dental_project.Repositories
{
    public interface IRepository
    {
        Task<List<Contact>> GetContactUs();
        Task<List<HeroSection>> GetHeroSection();
        Task<List<NavigationBar>> GetNavigationBar();
        Task<List<Icon>> GetIcon();
    }

    public class Repository : IRepository
    {
        private readonly DataBaseConnection _DatebaseConnection;

        public Repository(DataBaseConnection dbconnection)
        {
            _DatebaseConnection = dbconnection;
        }

        public async Task<List<Contact>> GetContactUs()
        {
            try
            {
                using (var connection = new SqlConnection(_DatebaseConnection.ConnectionString))
                {
                    var contactList = await connection.QueryAsync<Contact>("[dbo].[GetContact]", commandType: System.Data.CommandType.StoredProcedure);
                    return contactList.ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error Fetching Contact Us information", ex);
            }
        }

        public async Task<List<HeroSection>> GetHeroSection()
        {
            try
            {
                using (var connection = new SqlConnection(_DatebaseConnection.ConnectionString))
                {
                    var heroSectionList = await connection.QueryAsync<HeroSection>("[dbo].[GetHeroSection]", commandType: System.Data.CommandType.StoredProcedure);
                    return heroSectionList.ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error Fetching Hero Section information", ex);
            }
        }

        public async Task<List<NavigationBar>> GetNavigationBar()
        {
            try
            {
                using (var connection = new SqlConnection(_DatebaseConnection.ConnectionString))
                {
                    var navigationBarList = await connection.QueryAsync<NavigationBar>("[dbo].[GetNavigationBar]", commandType: System.Data.CommandType.StoredProcedure);
                    return navigationBarList.ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error Fetching Navigation Bar information", ex);
            }
        }

        public async Task<List<Icon>> GetIcon()
        {
            try
            {
                using (var connection = new SqlConnection(_DatebaseConnection.ConnectionString))
                {
                    var iconList = await connection.QueryAsync<Icon>("[dbo].[GetIcon]", commandType: System.Data.CommandType.StoredProcedure);
                    return iconList.ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error Fetching Icon information", ex);
            }
        }
    }
}
