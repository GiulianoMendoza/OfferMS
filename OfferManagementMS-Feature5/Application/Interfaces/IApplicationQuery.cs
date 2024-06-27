using Application.DTO.Pagination;
using Domain.Entities;

namespace Application.Interfaces
{
    public interface IApplicationQuery : IQuery<Aplication, int>
    {
        Task<Paged<Aplication>> RecoveryAllForCandidate(Parameters parameters, Guid userId, int? statusTypeId);
        Task<Paged<Aplication>> RecoveryAllForCompany(Parameters parameters, Guid offerId, int? statusTypeId);
    }

}