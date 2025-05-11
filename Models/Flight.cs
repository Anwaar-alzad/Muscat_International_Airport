namespace EntityFramework;

public class Flight
{
    public required string DepartureCity { get; set; }
    public required string DestinationCity { get; set; }
    //     departure time and arrival time and flight status and Gate
    // number that will be used for the flight
    public TimeOnly DepartureTime { get; set; }
    public TimeOnly ArrivalTime { get; set; }

    public FlightStatus flightStatus { get; set; }


}
