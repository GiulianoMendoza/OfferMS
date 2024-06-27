using Application.DTO.Error;
using Application.DTO.Pagination;
using Application.DTO.Response;
using Application.Interfaces;
using AutoMapper;
using Domain.Entities;

namespace Application.UseCase.Services
{
    public class OfferQueryService : IOfferQueryService
    {
        private readonly IOfferQuery _query;
        private readonly ICompanyApi _api;
        private readonly IMapper _mapper;

        public OfferQueryService(IOfferQuery query, IMapper mapper, ICompanyApi api = null)
        {
            _query = query;
            _mapper = mapper;
            _api = api;
        }

        public async Task<Paged<OfferMinimalResponse>> GetAllOfferByFilters(
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
            )
        {
            try
            {
                if (pageNumber <= 0 || pageSize <= 0)
                {
                    throw new BadRequestException("Ingrese valores mayores que cero (0) para pageNumber y pageSize.");
                }
                Parameters parameters = new Parameters(pageNumber, pageSize);

                Paged<Offer> offers = await _query.RecoveryAllOffers(parameters, title, companies, jobOfferMode, jobOfferType, province, studyType, categories, skills, availabilityToTravel, availabilityChangeOfResidence, from, to);

                List<OfferMinimalResponse> offerResponses = new();

                
                foreach (var offer in offers.Data)
                {
                    var response = _mapper.Map<OfferMinimalResponse>(offer);

                    var apiResponse = await _api.GetById<HTTPResponse<CompanyMinimalResponse>>(offer.CompanyId, "");
                    response.Company = apiResponse.Result;

                    response.Ubication = new UbicationResponse
                    {
                        Province = offer.City.Province.Name,
                        City = offer.City.Name
                    };
                    offerResponses.Add(response);
                }
                    

                return new Paged<OfferMinimalResponse>(offerResponses, offers.MetaData.TotalCount, parameters.PageNumber, parameters.PageSize);
            }
            catch (Exception e)
            {
                if (e is HTTPError) { throw; }
                throw new InternalServerErrorException(e.Message);
            }
        }

        public async Task<OfferResponse> GetById(Guid id)
        {
            try
            {
                var offer = await _query.RecoveryById(id);

                var response = _mapper.Map<OfferResponse>(offer);
                response.Ubication = new UbicationResponse
                {
                    Province = offer.City.Province.Name,
                    City = offer.City.Name
                };
                response.JobOfferMode = _mapper.Map<JobOfferModeResponse>(offer.JobOfferMode);
                response.StudyType = _mapper.Map<StudyTypeResponse>(offer.StudyType);

                offer.OfferCategories.ForEach(c =>
                {
                    response.Categories.Add(_mapper.Map<CategoryResponse>(c.Category));
                });
                offer.OfferSkills.ForEach(sk =>
                {
                    response.Skills.Add(_mapper.Map<SkillResponse>(sk.Skill));
                });

                var apiResponse = await _api.GetById<HTTPResponse<CompanyMinimalResponse>>(offer.CompanyId, "");
                response.Company = apiResponse.Result;

                return response;
            }
            catch (Exception e)
            {
                if (e is HTTPError) { throw; }
                throw new InternalServerErrorException(e.Message);
            }
        }

        Task<Paged<OfferResponse>> IQueryService<OfferResponse, Guid>.GetAllPaged(int pageNumber, int pageSize)
        {
            throw new NotImplementedException();
        }
    }
    
}
