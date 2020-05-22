using bootstrap.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace bootstrap.services
{
    public interface IOfFireAndIceClient
    {
        Task<IEnumerable<FireAndIceBookAPI>> GetBooks();
    }

    public class OfFireAndIceClient : IOfFireAndIceClient
    {
        private string _endPoint = "https://www.anapioficeandfire.com/api";
        private HttpClient _client = new HttpClient();

        public async Task<IEnumerable<FireAndIceBookAPI>> GetBooks()
        {
            try
            {
                var url = $"{_endPoint}/books";

                var response = await _client.GetAsync(url); // Making an http request to the client

                var json = await response.Content.ReadAsStringAsync(); // converting the compressed content into a string

                var result = JsonSerializer.Deserialize<IEnumerable<FireAndIceBookAPI>>(json); // Deserialzing the string content INTO a C# object
                return result;
            }
            catch (HttpRequestException e)
            {
                // retry logic
                Console.WriteLine("Failed to establish connection to server");
                throw;
            }
        }
    }
}
