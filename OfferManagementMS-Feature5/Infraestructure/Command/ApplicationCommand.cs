using Application.DTO.Error;
using Application.Interfaces;
using Domain.Entities;
using Infraestructure.Persistence;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace Infraestructure.Command
{
    public class ApplicationCommand : IApplicationCommand
    {
        private readonly AppDbContext _context;

        public ApplicationCommand(AppDbContext context)
        {
            _context = context;
        }

        public async Task<Aplication> Insert(Aplication entity)
        {
            var applicatinExist = await _context.Applications.
                FirstOrDefaultAsync(a => (a.OfferId == entity.OfferId) && (a.UserId == entity.UserId));

            if (applicatinExist != null) { throw new ConflictException("El usuario ha aplicado a la oferta anteriormente."); }

            await _context.AddAsync(entity);
            await _context.SaveChangesAsync();

            var applicationAdded = await _context.Applications
                .Include(a => a.ApplicationStatusType)
                .Include(a => a.Offer)
                    .ThenInclude(o => o.City)
                        .ThenInclude(c => c.Province)
                .Include(a => a.Offer)
                    .ThenInclude(jom => jom.JobOfferMode)
                .FirstOrDefaultAsync(a => (a.ApplicationId == entity.ApplicationId) && (a.Status));

            return applicationAdded;
        }

        public async Task Remove(int id)
        {
            var application = await _context.Applications
                .FirstOrDefaultAsync(a => (a.ApplicationId == id) && (a.Status));

            if (application == null) { throw new NotFoundException("La application con el ID " + id + " no fue encontrada.");}

            application.Status = false;
            await _context.SaveChangesAsync();
        }

        public async Task<Aplication> Update(int id, Aplication entity)
        {
            var application = await _context.Applications
                .FirstOrDefaultAsync(a => (a.ApplicationId == id) && (a.Status));

            if (application == null) { throw new NotFoundException("La application con el ID " + id + " no fue encontrada."); }

            //_context.Entry(application).CurrentValues.SetValues(entity);
            application.ApplicationStatusTypeId = entity.ApplicationStatusTypeId;
            await _context.SaveChangesAsync();

            var applicationUpdated = await _context.Applications
                .Include(a => a.ApplicationStatusType)
                .Include(a => a.Offer)
                    .ThenInclude(o => o.City)
                        .ThenInclude(c => c.Province)
                .Include(a => a.Offer)
                    .ThenInclude(jom => jom.JobOfferMode)
                .FirstOrDefaultAsync(a => (a.ApplicationId == application.ApplicationId) && (a.Status));

            return applicationUpdated;
        }
    }
}
