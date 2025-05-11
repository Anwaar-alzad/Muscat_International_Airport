namespace EntityFramework;

public class Passenger
{
    //     .passengers comes to the airport with their
    // national passport which we use to take a first name and, last name, date of birth,
    // gender, nationality, passport number, contact phone, contact email, each passenger has
    // baggage so the baggage has ID, and has the passenger id weight and tracking number,
    public required string FirstName { get; set; }
    public required string LastName { get; set; }
    public DateOnly DOB { get; set; }
    public char Gender { get; set; }
    public required string Nationality { get; set; }
    public int PassportNumber { get; set; }
    public required string ContactEmail { get; set; }

}
