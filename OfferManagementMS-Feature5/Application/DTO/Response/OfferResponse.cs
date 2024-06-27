namespace Application.DTO.Response
{
    public class OfferResponse
    {
        public Guid OfferId { get; set; }
        public CompanyMinimalResponse Company { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int MinSalary { get; set; }
        public int MaxSalary { get; set; }
        public JobOfferModeResponse JobOfferMode { get; set; }
        public DateTime PublicationDate { get; set; }
        public UbicationResponse Ubication { get; set; }
        public int? MinAge { get; set; }
        public int? MaxAge { get; set; }
        public int? Vacancies { get; set; }
        public bool AvailabilityToTravel { get; set; }
        public bool AvailabilityChangeOfResidence { get; set; }
        public StudyTypeResponse StudyType { get; set; }
        public int ApplicantQuantity { get; set; }

        public List<SkillResponse> Skills { get; set; } = new();
        public List<CategoryResponse> Categories { get; set; } = new();
    }
}
