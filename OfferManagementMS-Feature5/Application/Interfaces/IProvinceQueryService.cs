using Application.DTO.Response;

namespace Application.Interfaces
{
    public interface IProvinceQueryService : IQueryService<ProvincesResponse, int>
    {
        Task<List<ProvincesResponse>> GetAll();
    }
}
