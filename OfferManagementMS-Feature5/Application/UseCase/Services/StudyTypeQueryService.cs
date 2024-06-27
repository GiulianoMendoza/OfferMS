using Application.DTO.Error;
using Application.DTO.Pagination;
using Application.DTO.Response;
using Application.Interfaces;
using AutoMapper;
using Domain.Entities;

namespace Application.UseCase.Services
{
    public class StudyTypeQueryService : IStudyTypeQueryService
    {
        private readonly IStudyTypeQuery _query;
        private readonly IMapper _mapper;

        public StudyTypeQueryService(IStudyTypeQuery query, IMapper mapper)
        {
            _query = query;
            _mapper = mapper;
        }

        public async Task<List<StudyTypeResponse>> GetAll()
        {
            try
            {
                List<StudyTypeResponse> responseList = new();
                List<StudyType> studyTypes = await _query.RecoveryAll();
                studyTypes.ForEach(e =>
                {
                    var studyTypeResponse = _mapper.Map<StudyTypeResponse>(e);
                    responseList.Add(studyTypeResponse);
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

        public Task<Paged<StudyTypeResponse>> GetAllPaged(int pageNumber, int pageSize)
        {
            throw new NotImplementedException();
        }

        public async Task<StudyTypeResponse> GetById(int id)
        {
            try
            {
                if (id <= 0)
                {
                    throw new BadRequestException("Ingrese valores mayores que cero (0) para ID.");
                }
                var studyTypeResponse = await _query.RecoveryById(id);
                var response = _mapper.Map<StudyTypeResponse>(studyTypeResponse);
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
