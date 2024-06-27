using Domain.Entities;

namespace Application.Interfaces
{
    public interface ISkillQuery : IQuery<Skill, int>
    {
        Task<List<Skill>> RecoveryAll();
    }
    
}