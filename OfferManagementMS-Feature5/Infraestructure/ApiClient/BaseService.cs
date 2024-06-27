using Application.DTO.Request;
using Application.DTO.Response;
using Application.Interfaces;
using Newtonsoft.Json;
using System.Net;
using System.Net.Http.Headers;
using System.Text;
using System.Web;

namespace Infraestructure.ApiClient
{
    public abstract class BaseService<T> : IBaseService where T : class
    {

        public HTTPRequest responseModel { get ; set ; }
        public IHttpClientFactory _httpClient { get; set; }

        public BaseService(IHttpClientFactory httpClient)
        {
            this.responseModel = new();
            _httpClient= httpClient;
        }

        public async Task<T> SendAsync<T>(HTTPRequest apiRequest)
        {
            try
            {
                var client = _httpClient.CreateClient("ApiClient"); 
                HttpRequestMessage message = new HttpRequestMessage();
                message.Headers.Add("Accept", "application/json");

                if(apiRequest.Parameters == null)
                {
                    message.RequestUri = new Uri(apiRequest.Url);
                }
                else
                {
                    var builder = new UriBuilder(apiRequest.Url);
                    var query = HttpUtility.ParseQueryString(builder.Query);
                    query["PageNumber"] = apiRequest.Parameters.PageNumber.ToString();
                    query["PageSize"] = apiRequest.Parameters.PageSize.ToString();
                    builder.Query = query.ToString();
                    string url = builder.ToString(); 
                    message.RequestUri = new Uri(url);
                }
                
                                                
                if(apiRequest.Data !=null)
                {
                    message.Content = new StringContent(JsonConvert.SerializeObject(apiRequest.Data),
                              Encoding.UTF8, "application/json");
                }

                switch (apiRequest.ApiType)
                {
                    case Utilie.ApiType.POST:
                        message.Method = HttpMethod.Post;
                        break;
                    case Utilie.ApiType.PUT:
                        message.Method = HttpMethod.Put;
                        break;
                    case Utilie.ApiType.DELETE:
                        message.Method = HttpMethod.Delete;
                        break;
                    default:
                        message.Method = HttpMethod.Get;
                        break;
                }

                HttpResponseMessage apiResponse = null;

                if(!string.IsNullOrEmpty(apiRequest.Token))
                {
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", apiRequest.Token);
                }

                apiResponse = await client.SendAsync(message);
                var apiContent = await apiResponse.Content.ReadAsStringAsync();
                

                try
                {
                    var responseType = typeof(T);
                    var httpResponseType = typeof(HTTPResponse<>).MakeGenericType(responseType);
                    var response = JsonConvert.DeserializeObject(apiContent, httpResponseType) as dynamic;

                    if ( response !=null && (apiResponse.StatusCode == HttpStatusCode.BadRequest 
                                        || apiResponse.StatusCode== HttpStatusCode.NotFound))
                    {
                        response.StatusCode = HttpStatusCode.BadRequest;
                        var res = JsonConvert.SerializeObject(response);
                        var obj = JsonConvert.DeserializeObject<T>(res);
                        return obj;
                    }
                }
                catch (Exception ex)
                {
                    var errorResponse = JsonConvert.DeserializeObject<T>(apiContent);
                    return errorResponse;
                }

                var APIResponse = JsonConvert.DeserializeObject<T>(apiContent);
                return APIResponse;
            }
            catch (Exception ex)
            {
                var responseType = typeof(T);
                var httpResponseType = typeof(HTTPResponse<>).MakeGenericType(responseType);
                var dto = Activator.CreateInstance(httpResponseType);
                httpResponseType.GetProperty("Message").SetValue(dto, Convert.ToString(ex.Message));

                var res = JsonConvert.SerializeObject(dto);
                var responseEx = JsonConvert.DeserializeObject<T>(res);
                return responseEx;
            }
        }
    }
}
