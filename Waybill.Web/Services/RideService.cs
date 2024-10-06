using WayBill.Core.ViewModels;

namespace Waybill.Web.Services;

public class RideService(HttpClient httpClient)
{
    public async Task<IEnumerable<RideVm>> GetRidesAsync(CancellationToken cancellationToken = default)
    {
        List<RideVm>? rides = null;
        
        try
        {
            //var result = await httpClient.GetFromJsonAsAsyncEnumerable<RideVm>("/Ride", cancellationToken)
            await foreach (var ride in httpClient.GetFromJsonAsAsyncEnumerable<RideVm>("/Ride", cancellationToken))
            {
                if (ride is not null)
                {
                    rides ??= [];
                    rides.Add(ride);
                }
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
        
        return rides?.ToList() ?? [];
    } 
}