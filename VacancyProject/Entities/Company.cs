namespace VacancyProject.Entities
{
    public class Company
    {
        public int Id { get; set; }
        public string ProfileImage { get; set; }
        public string Name { get; set; }
        public string About { get; set; }
        public string Address { get; set; }
        public string ContactPhone { get; set; }
        public string ContactEmail { get; set; }
        public string Website { get; set; }
        public List<Vacancy> Vacancies { get; set; }
    }
}
