namespace EntityFramework;

public class Officer
{
    //     each officer has a personal
    // id and first name and last name and position and department and contact phone and
    // contact email
    public int Id { get; set; }
    public int FirstName { get; set; }
    public required string LastName { get; set; }
    public required string Position { get; set; }
    public required string Department { get; set; }
    public int ContactPhone { get; set; }
    public required string ContactEmail { get; set; }
}
