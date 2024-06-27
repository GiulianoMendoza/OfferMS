namespace Application.DTO.Response
{
    public class OfferMinimalResponse
    {
        public Guid OfferId { get; set; }
        public CompanyMinimalResponse Company { get; set; }
        public string Title { get; set; }
        public JobOfferModeResponse JobOfferMode { get; set; }
        public DateTime PublicationDate { get; set; }
        public UbicationResponse Ubication { get; set; }
    }
}
