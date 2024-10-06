using WayBill.Core.Models;

namespace Waybill.Application.Repositories;

public interface IRideRepository
{
    public Task<IEnumerable<Ride>> GetRidesAsync();
}