namespace VacancyProject.Entities
{
    public class Category
    {
        public int Id { get; set; }
        public string LogoImage { get; set; }
        public string Name { get; set; }
        public List<Vacancy> Vacancies { get; set; }
        public List<SubCategory> SubCategories { get; set; }
    }
}
