namespace Domain.Entities
{
    public class City
    {
        public int CityId { get; set; }
        public int ProvinceId { get; set; }
        public string Name { get; set; }
        public List<Offer> Offers { get; set; }
        public Province Province { get; set; }

    }
}
