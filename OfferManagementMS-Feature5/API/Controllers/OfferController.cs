using Application.DTO.Error;
using Application.DTO.Pagination;
using Application.DTO.Request;
using Application.DTO.Response;
using Application.Interfaces;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Security.Claims;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OfferController : ControllerBase
    {
        private readonly IOfferQueryService _queryService;
        private readonly IOfferCommandService _commandService;
        private readonly IMapper _mapper;
        private HTTPResponse<Object> _response;

        public OfferController(IOfferQueryService query, IMapper mapper, IOfferCommandService commandService)
        {
            _queryService = query;
            _mapper = mapper;
            _response = new();
            _commandService = commandService;
        }

        /// <summary>
        /// Returns a User given their ID
        /// </summary>
        /// <response code="200">Return a Offer as Result</response>

        [HttpGet("{id:Guid}")]
        [ProducesResponseType(typeof(HTTPResponse<OfferResponse>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(HTTPResponse<string>), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(HTTPResponse<string>), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(HTTPResponse<string>), StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult> GetById(Guid id)
        {
            try
            {
                _response.Result = await _queryService.GetById(id);
                _response.StatusCode = (HttpStatusCode)200;
                _response.Status = "OK";
                return new JsonResult(_response) { StatusCode = 200 };
            }
            catch (Exception e)
            {
                if (e is HTTPError)
                {
                    return new JsonResult(_mapper.Map<HTTPResponse<string>>(e)) { StatusCode = (int)((HTTPError)e).StatusCode };
                }
                return new JsonResult(_mapper.Map<HTTPResponse<string>>(new InternalServerErrorException("A server error has occurred."))) { StatusCode = 500 };
            }
        }


        /// <summary>
        /// Returns a page of records
        /// </summary>
        /// <response code="200">Returns a page of Offers as Result</response>

        [HttpGet]
        [ProducesResponseType(typeof(HTTPResponse<Paged<OfferMinimalResponse>>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(HTTPResponse<string>), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(HTTPResponse<string>), StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult> GetAll(
                [FromQuery] string? title,
                [FromQuery] List<Guid>? companies,
                [FromQuery] int? jobOfferMode,
                [FromQuery] int? jobOfferType,
                [FromQuery] List<int>? province,
                [FromQuery] int? studyType,
                [FromQuery] List<int>? categories,
                [FromQuery] List<int>? skills,
                [FromQuery] bool availabilityToTravel,
                [FromQuery] bool availabilityChangeOfResidence,
                [FromQuery] DateTime? from,
                [FromQuery] DateTime? to,
                int pageNumber = 1,
                int pageSize = 20
            )
        {
            try
            {
                _response.Result = await _queryService.GetAllOfferByFilters(pageNumber, pageSize, title, companies, jobOfferMode, jobOfferType, province, studyType, categories, skills, availabilityToTravel, availabilityChangeOfResidence, from, to);
                _response.StatusCode = (HttpStatusCode)200;
                _response.Status = "OK";
                return new JsonResult(_response) { StatusCode = 200 };
            }
            catch (Exception e)
            {
                if (e is HTTPError)
                {
                    return new JsonResult(_mapper.Map<HTTPResponse<string>>(e)) { StatusCode = (int)((HTTPError)e).StatusCode };
                }
                return new JsonResult(_mapper.Map<HTTPResponse<string>>(new InternalServerErrorException("A server error has occurred."))) { StatusCode = 500 };
            }
        }


        /// <summary>
        /// Register a Offer with their respective data
        /// </summary>
        /// <response code="201">Returns the Offer created as Result</response>

        [HttpPost]
        [Authorize(Roles = "company")]
        [ProducesResponseType(typeof(HTTPResponse<OfferResponse>), StatusCodes.Status201Created)]
        [ProducesResponseType(typeof(HTTPResponse<string>), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(HTTPResponse<string>), StatusCodes.Status409Conflict)]
        [ProducesResponseType(typeof(HTTPResponse<string>), StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult> CreateEntity(OfferRequest request)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    CustomValidation.ReturnError(ModelState);
                }
                var userId = Guid.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier));

                _response.Result = await _commandService.RegisterOffer(request, userId);
                _response.StatusCode = (HttpStatusCode)201;
                _response.Status = "Created";
                return new JsonResult(_response) { StatusCode = 201 };
            }
            catch (Exception e)
            {
                if (e is HTTPError)
                {
                    return new JsonResult(_mapper.Map<HTTPResponse<string>>(e)) { StatusCode = (int)((HTTPError)e).StatusCode };
                }
                return new JsonResult(_mapper.Map<HTTPResponse<string>>(new InternalServerErrorException("A server error has occurred."))) { StatusCode = 500 };
            }
        }


        /// <summary>
        /// Modify a User, request ID and the info to be updated
        /// </summary>
        /// <response code="200">Returns the updated Offer as Result</response>

        [HttpPut("{id:Guid}")]
        [Authorize(Roles = "company")]
        [ProducesResponseType(typeof(HTTPResponse<OfferResponse>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(HTTPResponse<string>), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(HTTPResponse<string>), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(HTTPResponse<string>), StatusCodes.Status409Conflict)]
        [ProducesResponseType(typeof(HTTPResponse<string>), StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult> UpdateEntity(Guid id, [FromBody] OfferRequest request)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    CustomValidation.ReturnError(ModelState);
                }

                _response.Result = await _commandService.Update(id, request);
                _response.StatusCode = (HttpStatusCode)200;
                _response.Status = "OK";
                return new JsonResult(_response) { StatusCode = 200 };
            }
            catch (Exception e)
            {
                if (e is HTTPError)
                {
                    return new JsonResult(_mapper.Map<HTTPResponse<string>>(e)) { StatusCode = (int)((HTTPError)e).StatusCode };
                }
                return new JsonResult(_mapper.Map<HTTPResponse<string>>(new InternalServerErrorException("A server error has occurred."))) { StatusCode = 500 };
            }
        }



        /// <summary>
        /// Delete an Offer given their ID
        /// </summary>
        /// <response code="200">Returns null in Result</response>

        [HttpDelete("{id:Guid}")]
        [Authorize(Roles = "company")]
        [ProducesResponseType(typeof(HTTPResponse<string>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(HTTPResponse<string>), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(HTTPResponse<string>), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(HTTPResponse<string>), StatusCodes.Status409Conflict)]
        [ProducesResponseType(typeof(HTTPResponse<string>), StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult> DeleteById(Guid id)
        {
            try
            {
                await _commandService.DeleteById(id);
                _response.StatusCode = (HttpStatusCode)200;
                _response.Status = "OK";
                return new JsonResult(_response) { StatusCode = 200 };
            }
            catch (Exception e)
            {
                if (e is HTTPError)
                {
                    return new JsonResult(_mapper.Map<HTTPResponse<string>>(e)) { StatusCode = (int)((HTTPError)e).StatusCode };
                }
                return new JsonResult(_mapper.Map<HTTPResponse<string>>(new InternalServerErrorException("A server error has occurred."))) { StatusCode = 500 };
            }
        }
    }
}
