namespace Application.DTO.Response
{
    public class ProvincesResponse
    {
        public int ProvinceId { get; set; }
        public string Name { get; set; }
        public int CountryId { get; set; }
        public List<CityResponse>? Cities { get; set; }

        public ProvincesResponse()
        {
            Cities = new();
        }
    }
}
