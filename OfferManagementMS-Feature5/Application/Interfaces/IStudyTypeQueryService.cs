using Application.DTO.Response;

namespace Application.Interfaces
{
    public interface IStudyTypeQueryService : IQueryService<StudyTypeResponse, int>
    {
        Task<List<StudyTypeResponse>> GetAll();
    }
}
