using Application.Entities;
using InfraStructure.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace StarsWarsWebapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StarsWarsController : ControllerBase
    {
        private readonly StarWarsApiService _starWarsApiService;

        public StarsWarsController(StarWarsApiService starWarsApiService)
        {
            _starWarsApiService = starWarsApiService;
        }

        [HttpGet("people")]
        public async Task<OkObjectResult> GetPeople()
        {
            string responsePeopleJson = await _starWarsApiService.GetPeople();
            
            return Ok(responsePeopleJson);
        }

        [HttpGet("starships")]
        public async Task<OkObjectResult> GetStarShips()
        {
            string responseStarShipsJson = await _starWarsApiService.GetStarShips();

            return Ok(responseStarShipsJson);
        }
    }
}
