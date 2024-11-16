namespace Entities.Models;
public class Airline
{
    public int Id { get; set; } = 1;
    public string Name { get; set; }
    public List<Flight> Flights { get; set; } = [];
    public List<Airplane> Planes { get; set; } = [];
    public Airline() {}
    public Airline(int id, string name)
    {
        Id = id;
        Name = name;
    }
    public void DisplayFlights()
    {
        foreach (Flight flight in Flights)
        {
            Console.WriteLine(flight);
        }
    }
    public void AddFlight(Flight flight)
    {
        Flights.Add(flight);
    }
    public void RemoveFlight(Flight flight)
    {
        Flights.Remove(flight);
    }
    public void CreateFleet()
    {

    }

    public Flight CreateFlight()
    {

    }

    // - Select airplane from fleet
    public Flight OrchestrateTestFlight()
    {
        // Create a new airplane
        Airplane airplane = new Airplane(1, 6);
        // Create a new flight
        Flights.Add(new Flight(Flights.Count + 1, airplane));
        // Add the flight to the airline
        Flights.Add(flight);
        // Book a seat

    }
}
