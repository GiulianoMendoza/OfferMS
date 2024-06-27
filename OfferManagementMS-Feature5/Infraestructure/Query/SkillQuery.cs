using Application.DTO.Error;
using Application.DTO.Pagination;
using Application.Interfaces;
using Domain.Entities;
using Infraestructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace Infraestructure.Query
{
    public class SkillQuery : ISkillQuery
    {

        private readonly AppDbContext _context;

        public SkillQuery(AppDbContext context)
        {
            _context = context;
        }
        
        public async Task<List<Skill>> RecoveryAll()
        {
            List<Skill> skills = await _context.Skills
                .ToListAsync();
            return skills;
        }

        public Task<Paged<Skill>> RecoveryAll(Parameters parameters)
        {
            throw new NotImplementedException();
        }

        public async Task<Skill> RecoveryById(int id)
        {
            var skill = await _context.Skills
                .FirstOrDefaultAsync(p => p.SkillId == id);

            if (skill == null)
            {
                throw new NotFoundException("El Skill con el ID " + id + " no fue encontrado.");
            }
            return skill;
        }


    }
}
