namespace Domain.Entities
{
    public class StudyType
    {
        public int StudyTypeId { get; set; }
        public string Name { get; set; }
        public List<Offer> Offers { get; set; }
    }
}
