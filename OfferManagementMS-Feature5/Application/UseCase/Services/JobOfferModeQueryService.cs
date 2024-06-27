using Application.DTO.Error;
using Application.DTO.Pagination;
using Application.DTO.Response;
using Application.Interfaces;
using AutoMapper;
using Domain.Entities;

namespace Application.UseCase.Services
{
    public class JobOfferModeQueryService : IJobOfferModeQueryService
    {
        private readonly IJobOfferModeQuery _query;
        private readonly IMapper _mapper;

        public JobOfferModeQueryService(IJobOfferModeQuery query, IMapper mapper)
        {
            _query = query;
            _mapper = mapper;
        }

        public async Task<List<JobOfferModeResponse>> GetAll()
        {
            try
            {
                List<JobOfferModeResponse> responseList = new();
                List<JobOfferMode> jobOfferModes = await _query.RecoveryAll();
                jobOfferModes.ForEach(e =>
                {
                    var categoryResponse = _mapper.Map<JobOfferModeResponse>(e);
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

        public Task<Paged<JobOfferModeResponse>> GetAllPaged(int pageNumber, int pageSize)
        {
            throw new NotImplementedException();
        }

        public async Task<JobOfferModeResponse> GetById(int id)
        {
            try
            {
                if (id <= 0)
                {
                    throw new BadRequestException("Ingrese valores mayores que cero (0) para ID.");
                }
                var jobOfferMode = await _query.RecoveryById(id);
                var response = _mapper.Map<JobOfferModeResponse>(jobOfferMode);
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
