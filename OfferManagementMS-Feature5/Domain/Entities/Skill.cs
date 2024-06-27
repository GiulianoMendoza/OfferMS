namespace Domain.Entities
{
    public class Skill
    {
        public int SkillId { get; set; }
        public string Name { get; set; }
        public List<OfferSkill> OfferSkills { get; set; }
    }
}
