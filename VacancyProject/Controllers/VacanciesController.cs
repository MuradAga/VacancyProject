using Microsoft.AspNetCore.Mvc;
using VacancyProject.Context;
using VacancyProject.Entities;
using VacancyProject.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace VacancyProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VacanciesController : ControllerBase
    {
        private readonly VacancyDbContext _db;
        public VacanciesController(VacancyDbContext db)
        {
            _db = db;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_db.Vacancies.ToList());
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(_db.Vacancies.Find(id));
        }

        [HttpPost]
        public void Post(VacancyPostModel vacancy)
        {
            Vacancy newVacancy = new() { Title = vacancy.Title, Description = vacancy.Description, DeadlineDate = vacancy.DeadlineDate, CityId = vacancy.CityId, CompanyId = vacancy.CompanyId, SubCategoryId = vacancy.SubCategoryId };
            newVacancy.ViewsCount = 0;
            newVacancy.CreatedAt = DateTime.Now;
            _db.Vacancies.Add(newVacancy);
            _db.SaveChanges();
        }

        // PUT api/<VacanciesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<VacanciesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
