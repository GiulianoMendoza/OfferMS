namespace Domain.Entities
{
    public class OfferCategory
    {
        public int OfferCategoryId { get; set; }
        public Guid OfferId { get; set; }
        public int CategoryId { get; set; }
        public Offer Offer { get; set; }
        public Category Category { get; set; }
    }
}
