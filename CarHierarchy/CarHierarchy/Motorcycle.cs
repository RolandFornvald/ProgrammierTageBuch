namespace CarHierarchy;

public sealed class Motorcycle : Vehicle
{
    private double _topSpeed { get; set; }
    public Motorcycle(string maker, string model, int year, double topSpeed) : base(maker, model, year)
    {
        _topSpeed = topSpeed;
    }
}