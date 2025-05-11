namespace EntityFramework;

public class AirLine
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public required int ContactNumber { get; set; }
    public required string ContactEmail { get; set; }
    public required string AirlineAgent { get; set; }
}
