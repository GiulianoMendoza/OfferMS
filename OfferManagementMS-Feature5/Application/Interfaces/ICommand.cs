namespace Application.Interfaces
{
    public interface ICommand<T, ID> where T : class
    {
        Task<T> Insert(T entity);
        Task<T> Update(ID id, T entity);
        Task Remove(ID id);
    }
}