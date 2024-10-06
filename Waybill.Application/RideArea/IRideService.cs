using WayBill.Core.ViewModels;

namespace Waybill.Application.RideArea;

public interface IRideService
{
    public Task<IEnumerable<RideVm>> GetRidesAsync();
}