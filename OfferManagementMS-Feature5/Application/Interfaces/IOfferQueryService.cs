using Application.DTO.Pagination;
using Application.DTO.Response;

namespace Application.Interfaces
{
    public interface IOfferQueryService : IQueryService<OfferResponse, Guid>
    {
        Task<Paged<OfferMinimalResponse>> GetAllOfferByFilters(
            int pageNumber, 
            int pageSize, 
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
            DateTime? to
        );
    }
}
