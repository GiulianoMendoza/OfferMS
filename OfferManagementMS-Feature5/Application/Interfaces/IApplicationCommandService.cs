using Application.DTO.Request;
using Application.DTO.Response;

namespace Application.Interfaces
{
    public interface IApplicationCommandService : ICommandService<ApplicationRequest, ApplicationCandidateResponse, ApplicationUpdateRequest, int>
    {
        Task<ApplicationCompanyResponse> UpdateApplication(int id, ApplicationUpdateRequest request);
        Task<ApplicationCandidateResponse> RegisterApplication(ApplicationRequest request, Guid userId);

    }
}
