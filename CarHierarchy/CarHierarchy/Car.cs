namespace CarHierarchy;

public sealed class Car : Vehicle
{
    private int _numSeats { get; set; }
    public Car(string maker, string model, int year, int numSeats) : base(maker, model, year)
    {
        _numSeats = numSeats;
    }
}