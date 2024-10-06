using Waybill.Application.Repositories;
using WayBill.Core.Models;

namespace Waybill.Infrastructure.Repositories;

public class RideRepository : IRideRepository
{
    public async Task<IEnumerable<Ride>> GetRidesAsync()
    {
        return new List<Ride>
            {
                new Ride
                {
                    Id = 1,
                    Car = new Car
                    {
                        Id = 101,
                        Make = "Tesla",
                        Model = "Model S",
                        NumberPlate = "ABC123",
                        TypeOfFuel = "Electric",
                        FuelConsumption = 0, // Electric cars may not have a traditional fuel consumption value
                        Year = 2022,
                        Color = "Red",
                        EngineSize = 0, // Electric cars don't have a traditional engine size
                        Transmission = "Automatic",
                        Description = "Fully electric luxury sedan"
                    },
                    Driver = new Driver
                    {
                        Id = 201,
                        FirstName = "John",
                        MiddleName = "Michael",
                        LastName = "Doe"
                    },
                    StartPoint = "City A",
                    EndPoint = "City B",
                    Distance = 150.75, // in kilometers or miles, depending on your system
                    DateTime = DateTime.Now.AddDays(-1) // Yesterday's date and time
                },
                new Ride
                {
                    Id = 2,
                    Car = new Car
                    {
                        Id = 102,
                        Make = "Ford",
                        Model = "F-150",
                        NumberPlate = "XYZ789",
                        TypeOfFuel = "Diesel",
                        FuelConsumption = 10.5, // Liters per 100 km for example
                        Year = 2020,
                        Color = "Blue",
                        EngineSize = 5.0, // in liters for a diesel engine
                        Transmission = "Manual",
                        Description = "Pickup truck with large cargo capacity"
                    },
                    Driver = new Driver
                    {
                        Id = 202,
                        FirstName = "Jane",
                        MiddleName = "Elizabeth",
                        LastName = "Smith"
                    },
                    StartPoint = "Town C",
                    EndPoint = "Town D",
                    Distance = 250.0, // in kilometers or miles, depending on your system
                    DateTime = DateTime.Now.AddDays(-2) // Two days ago
                }
            };
    }
}