using System.Runtime.Intrinsics.X86;

namespace EntityFramework;

public class Checkpoint
{
    public int Id { get; set; }
    public string Location { get; set; }
    // terminal Id
    // terminal name 
    // passenger capacity not sure to add it here - take it from Terminal class
    // and location
}
