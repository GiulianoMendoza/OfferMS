using Application.DTO.Error;
using Application.DTO.Response;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using Application.DTO.Pagination;
using Application.DTO.Request;
using Application.Interfaces;
using AutoMapper;
using Microsoft.AspNetCore.JsonPatch;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProvinceController : ControllerBase
    {
        private readonly IProvinceQueryService _service;
        private readonly IMapper _mapper;
        private readonly HTTPResponse<Object> _response;
        public ProvinceController(IProvinceQueryService provinceService, IMapper mapper)
        {
            _service = provinceService;
            _mapper = mapper;
            _response = new();
        }

        /// <summary>
        /// Retorna una Province especificando el ID
        /// </summary>
        /// <response code="200">Retorna una Province como resultado.</response>

        [HttpGet("{id:int}")]
        [ProducesResponseType(typeof(HTTPResponse<ProvincesResponse>), StatusCodes.Status200OK)]
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
                return new JsonResult(_mapper.Map<HTTPResponse<string>>(new InternalServerErrorException("Ha ocurrido un error en el servicodor."))) { StatusCode = 500 };
            }
        }
        /// <summary>
        /// Retorna una pagina de Province
        /// </summary>
        /// <response code="200">Retorna todas las Provincias como resultado.</response>

        [HttpGet]
        [ProducesResponseType(typeof(HTTPResponse<List<ProvincesResponse>>), StatusCodes.Status200OK)]
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
                return new JsonResult(_mapper.Map<HTTPResponse<string>>(new InternalServerErrorException("Ha ocurrido un error en el servicodor."))) { StatusCode = 500 };
            }
        }

    }
}
