using api.Models;
using System.Net.Http;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;
using System;

namespace api.Services
{
    public class StarWarsClient : IStarWarsClient
    {


        private string _endPoint = "https://swapi.dev/api";
        private HttpClient _client = new HttpClient();


        public async Task<StarWarsPeopleResponse> GetPeople()
        {

            try
            {
                var url = $"{_endPoint}/people/";

                var response = await _client.GetAsync(url); // Making an http request to the client

                var json = await response.Content.ReadAsStringAsync(); // converting the compressed content into a string

                var result = JsonSerializer.Deserialize<StarWarsPeopleResponse>(json); // Deserialzing the string content INTO a C# object
                return result;
            }
            catch(HttpRequestException e)
            {
                // retry logic
                Console.WriteLine("Failed to establish connection to server");
                throw;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

        }
    }

}
   
