using Application.DTO.Error;
using Application.DTO.Pagination;
using Application.Interfaces;
using Domain.Entities;
using Infraestructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace Infraestructure.Query
{
    public class StudyTypeQuery : IStudyTypeQuery
    {

        private readonly AppDbContext _context;

        public StudyTypeQuery(AppDbContext context)
        {
            _context = context;
        }
        
        public async Task<List<StudyType>> RecoveryAll()
        {
            List<StudyType> studyType = await _context.StudyTypes
                .ToListAsync();
            return studyType;
        }

        public Task<Paged<StudyType>> RecoveryAll(Parameters parameters)
        {
            throw new NotImplementedException();
        }

        public async Task<StudyType> RecoveryById(int id)
        {
            var studyType = await _context.StudyTypes
                .FirstOrDefaultAsync(p => p.StudyTypeId == id);

            if (studyType == null)
            {
                throw new NotFoundException("La Tipo de estudio con el ID " + id + " no fue encontrado.");
            }
            return studyType;
        }


    }
}
