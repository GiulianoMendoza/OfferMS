using Application.DTO.Response;

namespace Application.Interfaces
{
    public interface IJobOfferModeQueryService : IQueryService<JobOfferModeResponse, int>
    {
        Task<List<JobOfferModeResponse>> GetAll();
    }
}
