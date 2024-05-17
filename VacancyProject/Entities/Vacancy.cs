using System.ComponentModel.DataAnnotations;

namespace VacancyProject.Entities
{
    public class Vacancy
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int ViewsCount { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime DeadlineDate { get; set; }
        public int CityId { get; set; }
        public City City { get; set; }
        public int CompanyId { get; set; }
        public Company Company { get; set; }
        public int SubCategoryId { get; set; }
        public SubCategory SubCategory { get; set; }
    }
}
