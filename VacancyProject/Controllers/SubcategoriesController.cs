using Microsoft.AspNetCore.Mvc;
using VacancyProject.Context;
using VacancyProject.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace VacancyProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubcategoriesController : ControllerBase
    {
        private readonly VacancyDbContext _db;
        public SubcategoriesController(VacancyDbContext db)
        {
            _db = db;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_db.SubCategories.ToList());
        }

        [HttpPost]
        public void Post(int categoryId, string name)
        {
            SubCategory newSubCategory = new() { Name = name, CategoryId = categoryId };
            _db.SubCategories.Add(newSubCategory);
            _db.SaveChanges();
        }
    }
}
