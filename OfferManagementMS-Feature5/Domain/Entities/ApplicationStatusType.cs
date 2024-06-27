namespace Domain.Entities
{
    public class ApplicationStatusType
    {
        public int ApplicationStatusTypeId { get; set; }
        public string Name { get; set; }
        public List<Aplication> Applications { get; set; }
    }
}
