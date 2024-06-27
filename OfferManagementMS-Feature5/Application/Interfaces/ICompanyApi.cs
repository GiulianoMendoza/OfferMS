namespace Application.Interfaces
{
    public interface ICompanyApi : IBaseService
    {
        Task<T> GetById<T>(Guid id, string token);
    }
}
