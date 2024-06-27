using Application.DTO.Error;
using Application.Interfaces;
using Domain.Entities;
using Infraestructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace Infraestructure.Command
{
    public class OfferCommand : IOfferCommand
    {
        private readonly AppDbContext _context;

        public OfferCommand(AppDbContext context)
        {
            _context = context;
        }

        public async Task<Offer> Insert(Offer entity)
        {
            await _context.AddAsync(entity);
            await _context.SaveChangesAsync();

            var company = await _context.Offers
                .Include(c => c.City)
                .ThenInclude(p => p.Province)
                .Include(st => st.StudyType)
                .Include(os => os.OfferSkills)
                .ThenInclude(s => s.Skill)
                .Include(jom => jom.JobOfferMode)
                .Include(oc => oc.OfferCategories)
                .ThenInclude(c => c.Category)
                .Include(a => a.Applications)
                .ThenInclude(ast => ast.ApplicationStatusType)
                .FirstOrDefaultAsync(u => (u.OfferId == entity.OfferId) && (u.Status));

            return company;
        }

        public async Task Remove(Guid id)
        {
            var company = await _context.Offers
                .FirstOrDefaultAsync(u => (u.OfferId == id) && (u.Status));
            if (company == null)
            {
                throw new NotFoundException("La Oferta con el ID " + id + " no fue encontrada.");
            }
            company.Status = false;
            company.Applications?.ForEach(a => a.Status = false);

            await _context.SaveChangesAsync();
        }

        public async Task<Offer> Update(Guid id, Offer entity)
        {
            //Search
            var offerToUpdate = await _context.Offers
                .Include(o => o.OfferCategories)
                .Include(o => o.OfferSkills)
                .FirstOrDefaultAsync(o => (o.OfferId == entity.OfferId) && (o.Status));

            if (offerToUpdate == null)
            {
                throw new NotFoundException("La Oferta con el ID " + entity.OfferId + " no fue encontrada.");
            }

            //Update
            _context.OfferCategories.RemoveRange(offerToUpdate.OfferCategories.ToList());
            _context.OfferSkills.RemoveRange(offerToUpdate.OfferSkills.ToList());

            offerToUpdate.OfferCategories = entity.OfferCategories;
            offerToUpdate.OfferSkills = entity.OfferSkills;
            _context.Entry(offerToUpdate).CurrentValues.SetValues(entity);
            await _context.SaveChangesAsync();

            //Recovery all info
            var updatedOffer = await _context.Offers
                .Include(c => c.City)
                .ThenInclude(p => p.Province)
                .Include(st => st.StudyType)
                .Include(os => os.OfferSkills)
                .ThenInclude(s => s.Skill)
                .Include(jom => jom.JobOfferMode)
                .Include(oc => oc.OfferCategories)
                .ThenInclude(c => c.Category)
                .Include(a => a.Applications)
                .ThenInclude(ast => ast.ApplicationStatusType)
                .FirstOrDefaultAsync(o => (o.OfferId == entity.OfferId) && (o.Status));

            return updatedOffer;
        }
    }
}
