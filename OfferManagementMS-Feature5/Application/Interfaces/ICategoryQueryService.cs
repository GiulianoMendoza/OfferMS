using Application.DTO.Response;

namespace Application.Interfaces
{
    public interface ICategoryQueryService : IQueryService<CategoryResponse, int>
    {
        Task<List<CategoryResponse>> GetAll();
    }
}
