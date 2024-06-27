namespace Domain.Entities
{
    public class JobOfferMode
    {
        public int JobOfferModeId { get; set; }
        public string Name { get; set; }
        public List<Offer> Offers { get; set; }

    }
}
