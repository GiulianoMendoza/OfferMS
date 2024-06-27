namespace Domain.Entities
{
    public class Country
    {
        public int CountryId { get; set; }
        public string Name { get; set; }
        public List<Province> Provinces { get; set; }

    }
}
