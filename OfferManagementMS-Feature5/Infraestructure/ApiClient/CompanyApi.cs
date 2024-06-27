using Application.DTO.Request;
using Application.DTO.Response;
using Application.Interfaces;
using Microsoft.Extensions.Configuration;

namespace Infraestructure.ApiClient
{
    public class CompanyApi : BaseService<CompanyMinimalResponse>, ICompanyApi
    {
        private readonly string _url;

        public CompanyApi(IHttpClientFactory httpClient, IConfiguration configuration) : base(httpClient)
        {
            _url = configuration["ServiceUrls:API_URL_USER_MANAGMENT"];
        }

        public Task<T> GetById<T>(Guid id, string token)
        {
            return SendAsync<T>(new HTTPRequest()
            {
                ApiType = Utilie.ApiType.GET,
                Url = _url + "Company/" + id,
                Token = token
            });
        }
    }
}
