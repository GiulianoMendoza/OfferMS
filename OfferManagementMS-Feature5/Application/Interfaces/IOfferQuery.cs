using Application.DTO.Pagination;
using Domain.Entities;

namespace Application.Interfaces
{
    public interface IOfferQuery
    {
        Task<Offer> RecoveryById(Guid id);

        Task<Paged<Offer>> RecoveryAllOffers(
                Parameters parameters, 
                string? title,
                List<Guid>? companies,
                int? jobOfferMode,
                int? jobOfferType,
                List<int>? province,
                int? studyType,
                List<int>? categories,
                List<int>? skills,
                bool availabilityToTravel,
                bool availabilityChangeOfResidence,
                DateTime? from,
                DateTime? to);
    }
    
}