namespace VacancyProject.Models
{
    public class VacancyPutModel
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DeadlineDate { get; set; }
        public int CityId { get; set; }
        public int SubCategoryId { get; set; }
    }
}
