using Domain.Entities;

namespace Application.Interfaces
{
    public interface IStudyTypeQuery : IQuery<StudyType, int>
    {
       Task<List<StudyType>> RecoveryAll();
    }
    
}