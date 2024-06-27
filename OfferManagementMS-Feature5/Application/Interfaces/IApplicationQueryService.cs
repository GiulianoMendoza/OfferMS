using Application.DTO.Pagination;
using Application.DTO.Response;

namespace Application.Interfaces
{
    public interface IApplicationQueryService : IQueryService<ApplicationCandidateResponse, int>
    {
        Task<Paged<ApplicationCandidateResponse>> GetAllPagedForCandidate(int pageNumber, int pageSize, Guid userId, int? statusTipeId);
        Task<Paged<ApplicationCompanyResponse>> GetAllPagedForCompany(int pageNumber, int pageSize, Guid offerId, int? statusTipeId);
    }
}
