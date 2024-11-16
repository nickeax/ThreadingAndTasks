namespace Entities.Models;
public class Flight
{
    public Flight(){}
    public Flight(int id, Airplane airplane)
    {
        Id = id;
        Airplane = airplane;
    }
    public int Id { get; set; }
    public Airplane Airplane { get; set; }
    public List<Endpoint> Journey { get; set; } = [];
}
