namespace Domain.Entities
{
    public class OfferSkill
    {
        public int OfferSkillId { get; set; }
        public int SkillId { get; set; }
        public Guid OfferId { get; set; }
        public Skill Skill { get; set; }
        public Offer Offer { get; set; }
    }
}
