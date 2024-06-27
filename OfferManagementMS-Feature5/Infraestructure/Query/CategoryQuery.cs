using Application.DTO.Error;
using Application.DTO.Pagination;
using Application.Interfaces;
using Domain.Entities;
using Infraestructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace Infraestructure.Query
{
    public class CategoryQuery : ICategoryQuery
    {

        private readonly AppDbContext _context;

        public CategoryQuery(AppDbContext context)
        {
            _context = context;
        }
        
        
        public async Task<List<Category>> RecoveryAll()
        {
            List<Category> categories = await _context.Categories
                .ToListAsync();
            return categories;
        }

        public Task<Paged<Category>> RecoveryAll(Parameters parameters)
        {
            throw new NotImplementedException();
        }

        public async Task<Category> RecoveryById(int id)
        {
            var category = await _context.Categories
                .FirstOrDefaultAsync(c => c.CategoryId == id);

            if (category == null)
            {
                throw new NotFoundException("La Categoria con el ID " + id + " no fue encontrada.");
            }
            return category;
        }
    }
}
