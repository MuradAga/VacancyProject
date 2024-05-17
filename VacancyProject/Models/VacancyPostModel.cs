using VacancyProject.Entities;

namespace VacancyProject.Models
{
    public class VacancyPostModel
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DeadlineDate { get; set; }
        public int CityId { get; set; }
        public int CompanyId { get; set; }
        public int SubCategoryId { get; set; } 
    }
}
