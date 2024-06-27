using Application.DTO.Pagination;
using Domain.Entities;

namespace Application.Interfaces
{
    public interface IJobOfferModeQuery : IQuery<JobOfferMode, int>
    {
        Task<List<JobOfferMode>> RecoveryAll();

    }
    
}