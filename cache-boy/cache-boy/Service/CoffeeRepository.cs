using cache_boy.Models.Coffee.Repository;
using Dapper;
using Microsoft.Extensions.Options;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace cache_boy.Service
{
    public class CoffeeRepository : ICoffeeRepository
    {
        private string _connectionString; // WINDDOWS USER
        // private string _connectionString = "Server=myServerAddress;Database=myDataBase;User Id = myUsername; Password=myPassword;  MAC USER"


        public CoffeeRepository(IOptions<DatabaseConfig> config)
        {
            _connectionString = config.Value.ConnectionString;
        }

        public async Task<IEnumerable<CoffeeDBO>> SelectAllCoffee()
        {
            const string queryString = "Select * from [dbo].Coffee";

            using (var connection = new SqlConnection(_connectionString))
            {
                IEnumerable<CoffeeDBO> orderDetail = await connection.QueryAsync<CoffeeDBO>(queryString);

                return orderDetail;
            }
        }

        public bool InsertIntoCoffee(CoffeeDBO model)
        {
            var queryString = @$"INSERT INTO Coffee (Name, Price, Description) 
                                VALUES(@{nameof(CoffeeDBO.Name)}, @{nameof(CoffeeDBO.Price)}, @{nameof(CoffeeDBO.Description)});";

            using (var connection = new SqlConnection(_connectionString))
            {
                try
                {
                    var orderDetail = connection.ExecuteAsync(queryString, model);
                    return true;
                } 
                catch
                {
                    return false;
                }
            }
        }

        public bool UpdateSelectedCoffee(CoffeeDBO model)
        {
            var queryString = @$"UPDATE Coffee
                                SET 
	                                Name = @Name, 
	                                Description = @Description, 
	                                Price = @Price
                                WHERE ID = @ID; ";

            using (var connection = new SqlConnection(_connectionString))
            {
                try
                {
                    var orderDetail = connection.Execute(queryString, model);
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }

        public CoffeeDBO SelectOneCoffee(int ID)
        {
            var query = @"Select * From Coffee
                         WHERE ID = @ID";

            using (var connection = new SqlConnection(_connectionString))
            {
                var orderDetail = connection.Query<CoffeeDBO>(query, new { ID }).FirstOrDefault();

                return orderDetail;
            }
        }

        public bool DeleteSelectedCoffee(int ID)
        {
            var query = @"DELETE FROM Coffee WHERE ID = @ID;";


            using (var connection = new SqlConnection(_connectionString))
            {
                try
                {
                    var orderDetail = connection.Execute(query, new { ID });
                    return true;
                }
                catch
                {

                    return false;
                }
            }
        }

    }
}
