namespace WayBill.Core.Models;

public class Ride
{
    public int Id { get; set; }
    
    public required Car Car { get; set; }
    
    public required Driver Driver { get; set; }

    public required string StartPoint { get; set; }
    
    public required string EndPoint { get; set; }
    
    public double Distance { get; set; }
    
    public DateTime DateTime { get; set; }
}