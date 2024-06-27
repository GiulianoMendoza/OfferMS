namespace Domain.Entities
{
    public class Offer
    {
        public Guid OfferId { get; set; }
        public Guid CompanyId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int MinSalary { get; set; }
        public int MaxSalary { get; set; }
        public int JobOfferModeId { get; set; }
        public DateTime PublicationDate { get; set; } = DateTime.Now;
        public int CityId { get; set; }
        public int? MinAge { get; set; } = 18;
        public int? MaxAge { get; set; } = 65;
        public int Vacancies { get; set; }
        public bool AvailabilityToTravel { get; set; } = false;
        public bool AvailabilityChangeOfResidence { get; set; } = false;
        public int StudyTypeId { get; set; }
        public int ApplicantQuantity { get; set; } = 0;
        public bool Status { get; set; } = true;
        public JobOfferMode JobOfferMode { get; set; }
        public List<OfferCategory> OfferCategories { get; set; }
        public List<Aplication> Applications { get; set; }
        public List<OfferSkill> OfferSkills { get; set; }
        public City City { get; set; }
        public StudyType StudyType { get; set; }
    }
}
