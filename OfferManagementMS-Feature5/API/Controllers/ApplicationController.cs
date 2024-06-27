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
    [Route("api")]
    [ApiController]
    public class ApplicationController : ControllerBase
    {
        private readonly IApplicationQueryService _queryService;
        private readonly IApplicationCommandService _commandService;
        private readonly IMapper _mapper;
        private HTTPResponse<Object> _response;

        public ApplicationController(IApplicationQueryService service, IMapper mapper, IApplicationQuery queryService, IApplicationCommandService commandService)
        {
            _queryService = service;
            _commandService = commandService;
            _mapper = mapper;
            _response = new();
        }

        /// <summary>
        /// Busca una postulación por medio del ID
        /// </summary>
        /// <response code="200">Retorna información de la postulación.</response>

        [HttpGet("[controller]/{id:int}")]
        [Authorize(Roles = "jobuser")]
        [ProducesResponseType(typeof(HTTPResponse<ApplicationCandidateResponse>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(HTTPResponse<string>), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(HTTPResponse<string>), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(HTTPResponse<string>), StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult> GetById(int id)
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
        /// Retorna una pagina de postulaciones
        /// </summary>
        /// <response code="200">Retorna una pagina de Postulaciones como resultado.</response>

        [HttpGet("applicant/[controller]")]
        [Authorize(Roles = "jobuser")]
        [ProducesResponseType(typeof(HTTPResponse<Paged<ApplicationCandidateResponse>>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(HTTPResponse<string>), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(HTTPResponse<string>), StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult> GetAllCandidateApplication([FromQuery] int? statusTypeId, [FromQuery] int pageNumber = 1, [FromQuery] int pageSize = 10)
        {
            try
            {
                var userId = Guid.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier)); // Obtengo el ID del token

                _response.Result = await _queryService.GetAllPagedForCandidate(pageNumber, pageSize, userId, statusTypeId);
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
                return new JsonResult(_mapper.Map<HTTPResponse<string>>(new InternalServerErrorException("Ha ocurrido un error en el servicodor."))) { StatusCode = 500 };
            }
        }


        /// <summary>
        /// Retorna una pagina de postulaciones
        /// </summary>
        /// <response code="200">Retorna una pagina de Postulaciones como resultado.</response>

        [HttpGet("company/[controller]")]
        [Authorize(Roles = "company")]
        [ProducesResponseType(typeof(HTTPResponse<Paged<ApplicationCandidateResponse>>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(HTTPResponse<string>), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(HTTPResponse<string>), StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult> GetAllCompanyApplication(
            [FromQuery] int? statusTypeId,
            [FromQuery] Guid offerId,
            [FromQuery] int pageNumber = 1, 
            [FromQuery] int pageSize = 10
            )
        {
            try
            {
                // var userId = Guid.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier)); // Obtengo el ID del token

                _response.Result = await _queryService.GetAllPagedForCompany(pageNumber, pageSize, offerId, statusTypeId);
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
                return new JsonResult(_mapper.Map<HTTPResponse<string>>(new InternalServerErrorException("Ha ocurrido un error en el servicodor."))) { StatusCode = 500 };
            }
        }


        /// <summary>
        /// Realiza el registro de una postulación
        /// </summary>
        /// <response code="201">Retorna la información de la postulación registrada.</response>

        [HttpPost("[controller]")]
        [Authorize(Roles = "jobuser")]
        [ProducesResponseType(typeof(HTTPResponse<ApplicationCandidateResponse>), StatusCodes.Status201Created)]
        [ProducesResponseType(typeof(HTTPResponse<string>), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(HTTPResponse<string>), StatusCodes.Status409Conflict)]
        [ProducesResponseType(typeof(HTTPResponse<string>), StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult> CreateEntity(ApplicationRequest request)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    CustomValidation.ReturnError(ModelState);
                }

                var userId = Guid.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier)); // Obtengo el ID del token

                _response.Result = await _commandService.RegisterApplication(request, userId);
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
        /// Realiza la actualización de una postulación
        /// </summary>
        /// <response code="200">Retorna la información de la postulación actualizada.</response>
        
        [HttpPut("[controller]/{id:int}")]
        [Authorize(Roles = "company")]
        [ProducesResponseType(typeof(HTTPResponse<ApplicationCandidateResponse>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(HTTPResponse<string>), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(HTTPResponse<string>), StatusCodes.Status409Conflict)]
        [ProducesResponseType(typeof(HTTPResponse<string>), StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult> Update(int id, [FromBody] ApplicationUpdateRequest request)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    CustomValidation.ReturnError(ModelState);
                }
                _response.Result = await _commandService.UpdateApplication(id, request);
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
        /// Realiza la eliminación de una postulación
        /// </summary>
        /// <response code="200">No retorna nada.</response>

        [HttpDelete("[controller]/{id:int}")]
        [Authorize(Roles = "jobuser")]
        [ProducesResponseType(typeof(HTTPResponse<string>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(HTTPResponse<string>), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(HTTPResponse<string>), StatusCodes.Status409Conflict)]
        [ProducesResponseType(typeof(HTTPResponse<string>), StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult> Delete(int id)
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
