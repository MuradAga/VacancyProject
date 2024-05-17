namespace VacancyProject.Entities
{
    public class City
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Vacancy> Vacancies { get; set; }
    }
}
