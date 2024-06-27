using Application.DTO.Error;
using Application.DTO.Pagination;
using Application.Interfaces;
using Domain.Entities;
using Infraestructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace Infraestructure.Query
{
    public class OfferQuery : IOfferQuery
    {

        private readonly AppDbContext _context;

        public OfferQuery(AppDbContext context)
        {
            _context = context;
        }
        
        public async Task<Paged<Offer>> RecoveryAll(Parameters parameters)
        {
            IQueryable<Offer> offers = _context.Offers.Where(o => o.Status)
                .Include(c => c.City)
                    .ThenInclude(p => p.Province)
                .Include(st => st.StudyType)
                .Include(os => os.OfferSkills)
                    .ThenInclude(s => s.Skill)
                .Include(jom => jom.JobOfferMode)
                .Include(oc => oc.OfferCategories)
                    .ThenInclude(c => c.Category)
                .Include(a => a.Applications)
                    .ThenInclude(ast => ast.ApplicationStatusType);

            return await Paged<Offer>.ToPagedAsync(offers, parameters.PageNumber, parameters.PageSize);
        }

        public async Task<Paged<Offer>> RecoveryAllOffers(
            Parameters parameters,
            string? title,
            List<Guid>? companies,
            int? jobOfferMode,
            int? jobOfferType,
            List<int>? province,
            int? studyType,
            List<int>? categories,
            List<int>? skills,
            bool availabilityToTravel,
            bool availabilityChangeOfResidence,
            DateTime? from,
            DateTime? to
        )
        {
            IQueryable<Offer> offers = _context.Offers.Where(o => o.Status)
                .Include(c => c.City)
                    .ThenInclude(p => p.Province)
                .Include(st => st.StudyType)
                .Include(os => os.OfferSkills)
                    .ThenInclude(s => s.Skill)
                .Include(jom => jom.JobOfferMode)
                .Include(oc => oc.OfferCategories)
                    .ThenInclude(c => c.Category)
                .Include(a => a.Applications)
                    .ThenInclude(ast => ast.ApplicationStatusType);

            // Aplicar filtros
            if (!string.IsNullOrEmpty(title))
            {
                offers = offers.Where(o => o.Title.Contains(title) || o.Description.Contains(title));
            }

            if (companies != null && companies.Any())
            {
                offers = offers.Where(o => companies.Contains(o.CompanyId));
            }


            if (jobOfferMode.HasValue)
            {
                offers = offers.Where(o => o.JobOfferModeId == jobOfferMode);
            }

            //if (jobOfferType.HasValue)
            //{
            //    offers = offers.Where(o => o.JobOfferTypeId == jobOfferType);
            //}

            if (province != null && province.Any())
            {
                offers = offers.Where(o => province.Contains(o.City.ProvinceId));
            }

            if (studyType.HasValue)
            {
                offers = offers.Where(o => o.StudyTypeId == studyType);
            }

            if (categories != null && categories.Any())
            {
                offers = offers.Where(o => o.OfferCategories.Any(oc => categories.Contains(oc.CategoryId)));
            }

            if (skills != null && skills.Any())
            {
                offers = offers.Where(o => o.OfferSkills.Any(os => skills.Contains(os.SkillId)));
            }

            if (availabilityToTravel)
            {
                offers = offers.Where(o => o.AvailabilityToTravel == availabilityToTravel);
            }

            if (availabilityChangeOfResidence)
            {
                offers = offers.Where(o => o.AvailabilityChangeOfResidence == availabilityChangeOfResidence);
            }

            if (from.HasValue)
            {
                offers = offers.Where(o => o.PublicationDate >= from.Value);
            }

            if (to.HasValue)
            {
                offers = offers.Where(o => o.PublicationDate <= to.Value);
            }

            return await Paged<Offer>.ToPagedAsync(offers, parameters.PageNumber, parameters.PageSize);
        }


        public async Task<Offer> RecoveryById(Guid id)
        {
            var offer = await _context.Offers
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
                .FirstOrDefaultAsync(u => (u.OfferId == id) && (u.Status));

            if (offer == null)
            {
                throw new NotFoundException("La oferta con el ID " + id + " no fue encontrada.");
            }
            return offer;
        }


    }
}
