using Dapper;
using Dental_project.DataBase;
using Dental_project.Models;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Dental_project.Repositories
{

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
                throw new Exception("Error Fetching icon", ex);
            }

        }
        public async Task<List<HeroSection>> GetHeroSection()
        {
            try
            {
                using (var connection = new SqlConnection(_DatebaseConnection.ConnectionString))

                {
                    var HeroSectionList = await connection.QueryAsync<HeroSection>("[dbo].[GetHeroSection]", commandType: System.Data.CommandType.StoredProcedure);
                    return HeroSectionList.ToList();
                }

            }
            catch (Exception ex)
            {
                throw new Exception("Error Fetching icon", ex);
            }

        }
        public async Task<List<NavigationBar>> GetNavigationBar()
        {
            try
            {
                using (var connection = new SqlConnection(_DatebaseConnection.ConnectionString))

                {
                    var NavigationBarList = await connection.QueryAsync<NavigationBar>("[dbo].[GetNavigationBar]", commandType: System.Data.CommandType.StoredProcedure);
                    return  NavigationBarList.ToList();
                }

            }
            catch (Exception ex)
            {
                throw new Exception("Error Fetching icon", ex);
            }

        }
        public async Task<List<Icon>> GetIcon()
        {
            try
            {
                using (var connection = new SqlConnection(_DatebaseConnection.ConnectionString))

                {
                    var IconList = await connection.QueryAsync<Icon>("[dbo].[GetIcon]", commandType: System.Data.CommandType.StoredProcedure);
                    return IconList.ToList();
                }

            }
            catch (Exception ex)
            {
                throw new Exception("Error Fetching icon", ex);
            }

        }


    }
}
