using Application.DTO.Error;
using Application.DTO.Response;
using Application.Interfaces;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JobOfferModeController : ControllerBase
    {
        private readonly IJobOfferModeQueryService _service;
        private readonly IMapper _mapper;
        private HTTPResponse<Object> _response;

        public JobOfferModeController(IJobOfferModeQueryService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
            _response = new();
        }

        /// <summary>
        /// Returns a User given their ID
        /// </summary>
        /// <response code="200">Return a User as Result</response>

        [HttpGet("{id:int}")]
        [ProducesResponseType(typeof(HTTPResponse<JobOfferModeResponse>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(HTTPResponse<string>), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(HTTPResponse<string>), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(HTTPResponse<string>), StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult> GetById(int id)
        {
            try
            {
                _response.Result = await _service.GetById(id);
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
        /// <response code="200">Returns a page of Users as Result</response>

        [HttpGet]
        [ProducesResponseType(typeof(HTTPResponse<List<UserResponse>>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(HTTPResponse<string>), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(HTTPResponse<string>), StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult> GetAll()
        {
            try
            {
                _response.Result = await _service.GetAll();
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
