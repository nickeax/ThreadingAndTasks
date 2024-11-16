namespace Entities.Models;
public class Seat
{
    public Seat() {}
    public Seat(int row, SeatPosition position, SeatStatus status)
    {
        Row = row;
        Position = position;
        Status = status;
    }
    public int Row { get; set; }
    public SeatPosition Position { get; set; }
    public SeatStatus Status { get; set; }
    public string SeatNumber => $"{Row}{Position}";
    public override string ToString() => $"{SeatNumber} - {Status}";
}
