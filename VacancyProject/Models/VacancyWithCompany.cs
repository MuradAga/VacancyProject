namespace VacancyProject.Models
{
    public class VacancyWithCompany
    {
        public string CompanyProfileUrl { get; set; }
        public string CompanyName { get; set; }
        public string Title { get; set; }
        public DateOnly CreatedAt { get; set; }
        public int ViewsCount { get; set; }
    }
}
