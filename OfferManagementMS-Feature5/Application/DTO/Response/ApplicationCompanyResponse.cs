namespace Application.DTO.Response
{
    public class ApplicationCompanyResponse
    {
        public int ApplicationId { get; set; }
        public string OfferTitle { get; set; }
        public ApplicantMinimalResponse Applicant { get; set; }
        public string ApplicationStatusType { get; set; }
        public DateTime ApplicationDate { get; set; }
    }
}
