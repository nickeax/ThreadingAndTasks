namespace Entities.Models;
public class Airplane
{
    public int Id { get; set; } = 1;
    public int SeatingRows { get; set; } = 6;
    public Airplane()
    {
        Seats = new List<Seat>();
        for (int i = 1; i <= SeatingRows; i++)
        {
            Seats.Add(new Seat(i, SeatPosition.A, SeatStatus.Available));
            Seats.Add(new Seat(i, SeatPosition.B, SeatStatus.Available));
            Seats.Add(new Seat(i, SeatPosition.C, SeatStatus.Available));
            Seats.Add(new Seat(i, SeatPosition.D, SeatStatus.Available));
        }
    }
    public Airplane(int id, int seatingRows)
    {
        Id = id;
        SeatingRows = seatingRows;
        Seats = new List<Seat>();
        for (int i = 1; i <= SeatingRows; i++)
        {
            Seats.Add(new Seat(i, SeatPosition.A, SeatStatus.Available));
            Seats.Add(new Seat(i, SeatPosition.B, SeatStatus.Available));
            Seats.Add(new Seat(i, SeatPosition.C, SeatStatus.Available));
            Seats.Add(new Seat(i, SeatPosition.D, SeatStatus.Available));
        }
    }
    public List<Seat> Seats { get; set; }
    public void DisplaySeats()
    {
        foreach (Seat seat in Seats)
        {
            Console.WriteLine(seat);
        }
    }
    public void BookSeat(string passengerName, string seatNumber)
    {
        Seat seat = Seats.FirstOrDefault(s => s.SeatNumber == seatNumber);
        if (seat == null)
        {
            Console.WriteLine("Seat not found");
            return;
        }
        if (seat.Status == SeatStatus.Available)
        {
            seat.Status = SeatStatus.Booked;
            Console.WriteLine($"Seat {seatNumber} booked for {passengerName}");
        }
        else
        {
            Console.WriteLine($"Seat {seatNumber} is not available");
        }
    }
    public void CancelSeat(string passengerName, string seatNumber)
    {
        Seat seat = Seats.FirstOrDefault(s => s.SeatNumber == seatNumber);
        if (seat == null)
        {
            Console.WriteLine("Seat not found");
            return;
        }
        if (seat.Status == SeatStatus.Booked)
        {
            seat.Status = SeatStatus.Available;
            Console.WriteLine($"Seat {seatNumber} cancelled for {passengerName}");
        }
        else
        {
            Console.WriteLine($"Seat {seatNumber} is not booked");
        }
    }
}
