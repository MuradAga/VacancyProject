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

        [HttpGet("getByCategoryId")]
        public IActionResult GetByCategoryId(int categoryId) // 5
        {
            List<VacancyWithCompany> vacanciesResult = new();
            List<int> subCategories = _db.SubCategories.Where(sc => sc.CategoryId == categoryId).Select(sc => sc.Id).ToList();
            List<Vacancy> vacancies = _db.Vacancies.Where(v => subCategories.Contains(v.SubCategoryId)).ToList();

            foreach (var vacancy in vacancies)
            {
                VacancyWithCompany vacancyWithCompany = new()
                {
                    Title = vacancy.Title,
                    CreatedAt = DateOnly.FromDateTime(vacancy.CreatedAt),
                    ViewsCount = vacancy.ViewsCount,
                    CompanyProfileUrl = _db.Companies.Find(vacancy.CompanyId).ProfileImage,
                    CompanyName = _db.Companies.Find(vacancy.CompanyId).Name
                };
            }

            return Ok(vacanciesResult);
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

        [HttpPut("{id}")]
        public void Put(int id, VacancyPutModel vacancy)
        {
            Vacancy updateVacancy = _db.Vacancies.Find(id);
            updateVacancy.Title = vacancy.Title;
            updateVacancy.Description = vacancy.Description;
            updateVacancy.DeadlineDate = vacancy.DeadlineDate;
            updateVacancy.CityId = vacancy.CityId;
            updateVacancy.SubCategoryId = vacancy.SubCategoryId;
            _db.SaveChanges();
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _db.Vacancies.Remove(_db.Vacancies.Find(id));
            _db.SaveChanges();
        }
    }
}
