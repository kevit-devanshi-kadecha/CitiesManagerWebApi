using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CitiesManager.WebApi.Entities;
using CitiesManager.WebApi.Models;
using Asp.Versioning;

namespace CitiesManager.WebApi.Controllers.v2
{
    [ApiVersion("2.0")]
    public class CitiesController : CustomControllerBase
    {
        private readonly ApplicationDbContext _context;

        public CitiesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Cities
        [HttpGet]
        public async Task<ActionResult<IEnumerable<string?>>> GetCitiesData()
        {
            return await _context.CitiesData.OrderBy(temp => temp.CityName).Select(temp => temp.CityName).ToListAsync();
        }
    }
}
