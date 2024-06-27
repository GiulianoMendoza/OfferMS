using Application.DTO.Error;
using Application.DTO.Pagination;
using Application.DTO.Response;
using Application.Interfaces;
using AutoMapper;
using Domain.Entities;

namespace Application.UseCase.Services
{
    public class CategoryQueryService : ICategoryQueryService
    {
        private readonly ICategoryQuery _query;
        private readonly IMapper _mapper;

        public CategoryQueryService(ICategoryQuery query, IMapper mapper)
        {
            _query = query;
            _mapper = mapper;
        }

        public async Task<List<CategoryResponse>> GetAll()
        {
            try
            {
                List<CategoryResponse> responseList = new();
                List<Category> categories = await _query.RecoveryAll();
                categories.ForEach(e =>
                {
                    var categoryResponse = _mapper.Map<CategoryResponse>(e);
                    responseList.Add(categoryResponse);
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

        public Task<Paged<CategoryResponse>> GetAllPaged(int pageNumber, int pageSize)
        {
            throw new NotImplementedException();
        }

        public async Task<CategoryResponse> GetById(int id)
        {
            try
            {
                if (id <= 0)
                {
                    throw new BadRequestException("Ingrese valores mayores que cero (0) para ID.");
                }
                var category = await _query.RecoveryById(id);
                var response = _mapper.Map<CategoryResponse>(category);
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
