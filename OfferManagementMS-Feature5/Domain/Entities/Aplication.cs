namespace Domain.Entities
{
    public class Aplication
    {
        public int ApplicationId { get; set; }
        public int ApplicationStatusTypeId { get; set; } = 1;
        public Guid UserId { get; set; }
        public Guid OfferId { get; set; }
        public DateTime ApplicationDate { get; set; } = DateTime.Now;
        public bool Status { get; set; } = true;
        public Offer Offer { get; set; }
        public ApplicationStatusType ApplicationStatusType { get; set; }
    }
}
