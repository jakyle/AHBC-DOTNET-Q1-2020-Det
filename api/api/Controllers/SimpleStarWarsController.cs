using api.Models;
using api.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class SimpleStarWarsController : ControllerBase
    {
        private readonly IStarWarsClient _starWarsClient;

        public SimpleStarWarsController(IStarWarsClient starWarsClient)
        {
            _starWarsClient = starWarsClient;
        }


        [HttpGet]
        public async Task<IActionResult> GetPeople()
        {
            var clientResult = await _starWarsClient.GetPeople();  // Calling our star star wars client, and the client is reponsible for doing client things.

            var result = new SimpleStarWarsPeopleResponse();

            result.People = clientResult.results.Select(person => new SimplePerson
            {
                Name = person.name,
                HomeWorld = person.homeworld,
                BirthYear = person.birth_year,
                Films = person.films.ToList()
            })
            .ToList();

            return Ok(result);
        }

        [HttpGet]
        [Route("data")]
        public async Task<IActionResult> GetSomeData()
        {
            var data = "data";

            return Ok(data);
        }
    }
}
