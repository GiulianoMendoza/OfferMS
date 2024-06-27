namespace Application.Interfaces
{
    public interface ICommandService<Request, Response, UpdateRequest, ID> where Request : class where Response : class where UpdateRequest : class
    {
        Task<Response> Create(Request request);
        Task DeleteById(ID id);
        Task<Response> Update(ID id, UpdateRequest request);
    }
}
