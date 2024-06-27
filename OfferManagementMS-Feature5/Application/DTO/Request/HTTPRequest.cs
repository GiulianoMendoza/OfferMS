using Application.DTO.Pagination;
using static Application.DTO.Request.Utilie;

namespace Application.DTO.Request
{
    public class HTTPRequest
    {
        public ApiType ApiType { get; set; } = ApiType.GET;

        public string Url { get; set; }

        public object Data { get; set; }

        public string Token { get; set; }

        public MetaData Parameters { get; set; }
    }

}
