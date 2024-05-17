using Microsoft.AspNetCore.Mvc;
using VacancyProject.Context;
using VacancyProject.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace VacancyProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly VacancyDbContext _db;
        public CategoriesController(VacancyDbContext db)
        {
            _db = db;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_db.Categories.ToList());
        }

        [HttpPost]
        public void Post(string logoImage, string name)
        {
            Category newCategory = new() { LogoImage = logoImage, Name = name };
            _db.Categories.Add(newCategory);
            _db.SaveChanges();
        }
    }
}
