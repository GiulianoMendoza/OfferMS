using Application.DTO.Response;

namespace Application.Interfaces
{
    public interface ISkillQueryService : IQueryService<SkillResponse, int>
    {
        Task<List<SkillResponse>> GetAll();
    }
}
