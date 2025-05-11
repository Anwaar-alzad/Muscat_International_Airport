namespace EntityFramework;

public class Terminal
{
    public int Id { get; set; }
    public int Name { get; set; }
    public int Capacity { get; set; }
    public required string Location { get; set; }
}
