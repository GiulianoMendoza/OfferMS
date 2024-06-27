using Application.DTO.Error;
using Application.DTO.Pagination;
using Application.DTO.Response;
using Application.Interfaces;
using AutoMapper;
using Domain.Entities;

namespace Application.UseCase.Services
{
    public class ProvinceQueryService : IProvinceQueryService
    {
        private readonly IProvinceQuery _query;
        private readonly IMapper _mapper;

        public ProvinceQueryService(IProvinceQuery query, IMapper mapper)
        {
            _query = query;
            _mapper = mapper;
        }

        public async Task<List<ProvincesResponse>> GetAll()
        {
            try
            {
                List<ProvincesResponse> responseList = new();
                List<Province> provinces = await _query.GetAllProvince();
                provinces.ForEach(e =>
                {
                    var provinceresponse = _mapper.Map<ProvincesResponse>(e);
                    responseList.Add(provinceresponse);
                }
                );
                return responseList;
            }
            catch (Exception e)
            {
                if (e is HTTPError)
                {
                    throw;
                }
                throw new InternalServerErrorException(e.Message);
            }
        }

        public Task<Paged<ProvincesResponse>> GetAllPaged(int pageNumber, int pageSize)
        {
            throw new NotImplementedException();
        }

        public async Task<ProvincesResponse> GetById(int id)
        {
            try
            {
                if (id <= 0)
                {
                    throw new BadRequestException("Ingrese valores mayores que cero (0) para ID.");
                }
                var province = await _query.GetProvinceById(id);
                var response = _mapper.Map<ProvincesResponse>(province);
                (province.Cities).ForEach(city =>
                {
                    var entity = _mapper.Map<CityResponse>(city);
                    response.Cities.Add(entity);
                });
                return response;
            }
            catch (Exception e)
            {
                if (e is HTTPError)
                {
                    throw;
                }
                throw new InternalServerErrorException(e.Message);
            }
        }
    }
}
