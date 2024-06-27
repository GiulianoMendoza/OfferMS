using Application.DTO.Pagination;

namespace Application.Interfaces
{
    public interface IQueryService<Response, ID> where Response : class
    {
        Task<Paged<Response>> GetAllPaged(int pageNumber, int pageSize);
        Task<Response> GetById(ID id);
    }
}
