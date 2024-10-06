namespace Waybill.Web.Models;

public class Ride
{
    public int Id { get; set; }
    
    public required string Car { get; set; }
    
    public required string Driver { get; set; }

    public required string StartPoint { get; set; }
    
    public required string EndPoint { get; set; }
    
    public double Distance { get; set; }
    
    public DateTime RideDateTime { get; set; }
    
    public double SpeedometerReading{ get; set; }
    
    public DateTime ReleaseCarTime { get; set; }
    
    public string? CargoName { get; set; } 
}