namespace WayBill.Core.Models;

public class Driver
{
    public int Id { get; set; }

    public required string FirstName { get; init; }

    public required string MiddleName { get; init; }

    public required string LastName { get; init; }
}