using Application.DTO.Request;

namespace Application.Interfaces
{
    public interface IBaseService
    {
        public HTTPRequest responseModel { get; set; }

        Task<T> SendAsync<T>(HTTPRequest apiRequest);
    }
}
