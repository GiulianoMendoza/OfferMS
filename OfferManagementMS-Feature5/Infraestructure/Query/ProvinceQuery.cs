using Application.DTO.Error;
using Application.Interfaces;
using Domain.Entities;
using Infraestructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace Infraestructure.Query
{
    public class ProvinceQuery : IProvinceQuery
    {
        private readonly AppDbContext _context;
        public ProvinceQuery(AppDbContext DBcontext)
        {
            this._context = DBcontext;
        }
        public async Task<List<Province>> GetAllProvince()
        {
            List<Province> provinces = await _context.Provinces
                .ToListAsync();
            return provinces;
        }
        public async Task<Province> GetProvinceById(int provinceid)
        {
            var province =  await _context.Provinces
                .Include(c => c.Cities)
                .FirstOrDefaultAsync(p => p.ProvinceId == provinceid);

            if (province == null)
            {
                throw new NotFoundException("La Province con el ID " + provinceid + " no fue encontrada.");
            }

            return province;
        }
    }
}
