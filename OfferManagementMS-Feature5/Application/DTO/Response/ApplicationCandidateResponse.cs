namespace Application.DTO.Response
{
    public class ApplicationCandidateResponse
    {
        public int ApplicationId { get; set; }
        public string OfferTitle { get; set; }
        public Guid OfferId { get; set; }
        public CompanyMinimalResponse Company { get; set; }
        public string ApplicationStatusType { get; set; }
        public DateTime ApplicationDate { get; set; }
        public int ApplicationQuantity { get; set; }
    }
}
