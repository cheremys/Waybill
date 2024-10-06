namespace WayBill.Core.Models;

public class Car
{
    public int Id { get; set; }
    
    public required string Make { get; set; }
    
    public required string Model { get; set; }
    
    public required string NumberPlate { get; set; } // Car's registration number
    
    public required string TypeOfFuel { get; set; } // e.g., Petrol, Diesel, Electric
    
    public double FuelConsumption { get; set; } // Liters per 100 km or Miles per gallon
    
    public int Year { get; set; }
    
    public string? Color { get; set; }
    
    public double EngineSize { get; set; }
    
    public string? Transmission { get; set; } // Manual or Automatic
    
    public string? Description { get; set; }
}