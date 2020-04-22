using cache_boy.Models.Coffee.Repository;
using Dapper;
using Microsoft.Extensions.Caching.Memory;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace cache_boy.Service
{
    public class CoffeeRepository : ICoffeeRepository
    {
        private string _connectionString = "Data Source = DESKTOP-JGEHS55; Initial Catalog = CoffeeShop; Integrated Security=True"; // WINDDOWS USER
        // private string _connectionString = "Server=myServerAddress;Database=myDataBase;User Id = myUsername; Password=myPassword;  MAC USER"

        //public void AddCoffee(string coffeeName)
        //{
        //    Coffees.Add(coffeeName);
        //}

        //public void DeleteCoffee(string coffeeName)
        //{
        //    Coffees.Remove(coffeeName);
        //}

        public IEnumerable<CoffeeDBO> SelectAllCoffee()
        {
            const string queryString = "Select * from [dbo].Coffee";

            using (var connection = new SqlConnection(_connectionString))
            {
                IEnumerable<CoffeeDBO> orderDetail = connection.Query<CoffeeDBO>(queryString);

                return orderDetail;
            }
        }

        //public void UpdateCoffee(string newName, string oldName)
        //{
        //    var oldNameIndex = Coffees.IndexOf(oldName);
        //    Coffees[oldNameIndex] = newName;
        //}

        //private IList<string> GetCoffessAllCaps()
        //{
        //    // Looping way of doing the thing
        //    var coffeesAllCaps = new List<string>();
        //    foreach (var coffee in Coffees)
        //    {
        //        var allCapsCoffee = coffee.ToUpper();

        //        coffeesAllCaps.Add(allCapsCoffee);
        //    }

        //    // the Linq way
        //    return Coffees
        //        .Select(coffee => coffee.ToUpper())
        //        .ToList();
        //}

        //private IList<string> GetThreeWordCoffees()
        //{
        //    var coffeesWithOnlyThreeWords = new List<string>();
        //    foreach (var coffee in Coffees)
        //    {
        //        if (coffee.Split(" ").Length <= 3)
        //        {
        //            coffeesWithOnlyThreeWords.Add(coffee);
        //        }
        //    }


        //    var coffeesWithOnlyThreeWordsLinqEdition = Coffees
        //        .Where(coffee => {
        //            return coffee.Split(" ").Length <= 3;
        //         })
        //        .ToList();

        //    return coffeesWithOnlyThreeWordsLinqEdition;
        //}

        //private IList<string> GetThreeWordCoffesAllCaps()
        //{

        //    var name = "Darion".Select(letter => letter + 1).ToString();

        //    var coffeesWithOnlyThreeWordsLinqEdition = Coffees
        //        .Where(coffee => coffee.Split(" ").Length <= 3)
        //        .Select(coffee => coffee.ToUpper())
        //        .ToList();

        //    return coffeesWithOnlyThreeWordsLinqEdition;
        //}


    }
}
