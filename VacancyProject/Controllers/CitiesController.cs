using Microsoft.AspNetCore.Mvc;
using System;
using System.Numerics;
using VacancyProject.Context;
using VacancyProject.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace VacancyProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CitiesController : ControllerBase
    {
        private readonly VacancyDbContext _db;
        public CitiesController(VacancyDbContext db)
        {
            _db = db;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_db.Cities.ToList());
        }

        [HttpPost]
        public void Post(string name)
        {
            City newCity = new() { Name = name };
            _db.Cities.Add(newCity);
            _db.SaveChanges();
        }
    }
}
