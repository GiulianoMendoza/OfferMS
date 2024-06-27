using Application.DTO.Error;
using Application.DTO.Pagination;
using Application.Interfaces;
using Domain.Entities;
using Infraestructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace Infraestructure.Query
{
    public class ApplicationQuery : IApplicationQuery
    {

        private readonly AppDbContext _context;

        public ApplicationQuery(AppDbContext context)
        {
            _context = context;
        }
        
        public async Task<Paged<Aplication>> RecoveryAll(Parameters parameters)
        {
            IQueryable<Aplication> applications = _context.Applications.Where(a => a.Status)
                .Include(a => a.ApplicationStatusType)
                .Include(a => a.Offer)
                    .ThenInclude(o => o.City)
                        .ThenInclude(c => c.Province)
                .Include(a => a.Offer)
                    .ThenInclude(st => st.StudyType)
                .Include(a => a.Offer)
                    .ThenInclude(os => os.OfferSkills)
                        .ThenInclude(s => s.Skill)
                .Include(a => a.Offer)
                    .ThenInclude(jom => jom.JobOfferMode)
                .Include(a => a.Offer)
                    .ThenInclude(oc => oc.OfferCategories)
                        .ThenInclude(c => c.Category);
            
            return await Paged<Aplication>.ToPagedAsync(applications, parameters.PageNumber, parameters.PageSize);
        }

        public async Task<Paged<Aplication>> RecoveryAllForCandidate(Parameters parameters, Guid userId, int? statusTypeId)
        {
            IQueryable<Aplication> applications = _context.Applications.Where(a => a.Status && a.UserId == userId)
                .Include(a => a.ApplicationStatusType)
                .Include(a => a.Offer);

            if (statusTypeId.HasValue && statusTypeId.Value != 0)
            {
                applications = applications.Where(a => a.ApplicationStatusTypeId == statusTypeId);
            }

            return await Paged<Aplication>.ToPagedAsync(applications, parameters.PageNumber, parameters.PageSize);
        }

        public async Task<Paged<Aplication>> RecoveryAllForCompany(Parameters parameters, Guid offerId, int? statusTypeId)
        {
            IQueryable<Aplication> applications = _context.Applications.Where(a => a.Status && a.OfferId == offerId)
                .Include(a => a.ApplicationStatusType)
                .Include(a => a.Offer);

            if (statusTypeId.HasValue && statusTypeId.Value != 0)
            {
                applications = applications.Where(a => a.ApplicationStatusTypeId == statusTypeId);
            }

            return await Paged<Aplication>.ToPagedAsync(applications, parameters.PageNumber, parameters.PageSize);
        }

        public async Task<Aplication> RecoveryById(int id)
        {
            var application = await _context.Applications
                .Include(a => a.ApplicationStatusType)
                .Include(a => a.Offer)
                    .ThenInclude(o => o.City)
                        .ThenInclude(c => c.Province)
                .Include(a => a.Offer)
                    .ThenInclude(st => st.StudyType)
                .Include(a => a.Offer)
                    .ThenInclude(os => os.OfferSkills)
                        .ThenInclude(s => s.Skill)
                .Include(a => a.Offer)
                    .ThenInclude(jom => jom.JobOfferMode)
                .Include(a => a.Offer)
                    .ThenInclude(oc => oc.OfferCategories)
                        .ThenInclude(c => c.Category)
                .FirstOrDefaultAsync(a => (a.ApplicationId == id) && (a.Status));

            if (application == null)
            {
                throw new NotFoundException("La Application con el ID " + id + " no fue encontrada.");
            }
            return application;
        }


    }
}
