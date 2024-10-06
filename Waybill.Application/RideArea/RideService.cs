using Waybill.Application.Repositories;
using WayBill.Core.Models;
using WayBill.Core.ViewModels;

namespace Waybill.Application.RideArea;

public class RideService : IRideService
{
    private readonly IRideRepository _rideRepository;

    public RideService(IRideRepository rideRepository)
    {
        _rideRepository = rideRepository;
    }

    public async Task<IEnumerable<RideVm>> GetRidesAsync()
    {
        var rides = await _rideRepository.GetRidesAsync();

            var vms = rides.Select(r =>
                new RideVm
                {
                    Id = r.Id,
                    Car = r.Car.Model,
                    Driver = $"{r.Driver.FirstName} {r.Driver.LastName}",
                    StartPoint = r.StartPoint, 
                    EndPoint = r.EndPoint,
                    Distance = r.Distance,
                    RideDateTime = r.DateTime,
                    SpeedometerReading = r.Distance,
                    ReleaseCarTime = r.DateTime.AddHours(-1),
                    CargoName = "Electronics"
                });
            
            return vms;
    }
}