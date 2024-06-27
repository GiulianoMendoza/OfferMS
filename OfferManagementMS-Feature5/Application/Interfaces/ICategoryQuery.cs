using Domain.Entities;

namespace Application.Interfaces
{
    public interface ICategoryQuery : IQuery<Category, int>
    {
        Task<List<Category>> RecoveryAll();
    }
    
}