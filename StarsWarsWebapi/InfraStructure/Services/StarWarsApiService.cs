using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace InfraStructure.Services
{
    public class StarWarsApiService
    {
        private readonly HttpClient _httpClient;
        string peopleListApiUrl = "https://swapi.dev/api/people/";
        string starshipListApiUrl = "https://swapi.dev/api/starships/";
        public StarWarsApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<string> GetPeople()
        {
            return await _httpClient.GetStringAsync(this.peopleListApiUrl);
        }

        public async Task<string> GetPlanets()
        {
            return await _httpClient.GetStringAsync("planets/");
        }
        public async Task<string> GetStarShips()
        {
            return await _httpClient.GetStringAsync(this.starshipListApiUrl);
        }


        // Add similar methods for other endpoints (films, species, vehicles, starships)
    }
}
