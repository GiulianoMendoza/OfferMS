using Domain.Entities;

namespace Application.Interfaces
{
    public interface IOfferCommand : ICommand<Offer, Guid>
    {
    }
}
