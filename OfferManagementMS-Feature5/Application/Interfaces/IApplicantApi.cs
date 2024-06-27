namespace Application.Interfaces
{
    public interface IApplicantApi : IBaseService
    {
        Task<T> GetById<T>(Guid id, string token);
    }
}
