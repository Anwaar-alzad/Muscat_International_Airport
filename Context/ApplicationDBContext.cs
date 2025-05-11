using Microsoft.EntityFrameworkCore;

namespace EntityFramework;

public class ApplicationDBContext : DbContext
{

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=Companyxyz;Integrated Security=True;Connect Timeout=30;Encrypt=True;TrustServerCertificate=False;");
    }
    DbSet<Airport> Airports { get; set; }
    DbSet<AirLine> AirLines { get; set; }
    DbSet<Passenger> Passengers { get; set; }
    DbSet<Flight> Flights { get; set; }
    DbSet<Officer> Officers { get; set; }
    DbSet<Baggage> Baggages { get; set; }
    DbSet<Terminal> Terminals { get; set; }
    DbSet<Gate> Gates { get; set; }
    DbSet<Checkpoint> Checkpoints { get; set; }


    public ApplicationDBContext()
    {

    }

    // class POCO
    // DbSet<Generic> -> mapping object --> transfer







}
