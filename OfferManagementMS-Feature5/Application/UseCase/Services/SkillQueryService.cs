using Application.DTO.Error;
using Application.DTO.Pagination;
using Application.DTO.Response;
using Application.Interfaces;
using AutoMapper;
using Domain.Entities;

namespace Application.UseCase.Services
{
    public class SkillQueryService : ISkillQueryService
    {
        private readonly ISkillQuery _query;
        private readonly IMapper _mapper;

        public SkillQueryService(ISkillQuery query, IMapper mapper)
        {
            _query = query;
            _mapper = mapper;
        }

        public async Task<List<SkillResponse>> GetAll()
        {
            try
            {
                List<SkillResponse> responseList = new();
                List<Skill> skills = await _query.RecoveryAll();
                skills.ForEach(e =>
                {
                    var skillResponse = _mapper.Map<SkillResponse>(e);
                    responseList.Add(skillResponse);
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

        public Task<Paged<SkillResponse>> GetAllPaged(int pageNumber, int pageSize)
        {
            throw new NotImplementedException();
        }

        public async Task<SkillResponse> GetById(int id)
        {
            try
            {
                if (id <= 0)
                {
                    throw new BadRequestException("Ingrese valores mayores que cero (0) para ID.");
                }
                var skill = await _query.RecoveryById(id);
                var response = _mapper.Map<SkillResponse>(skill);
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
