namespace CarHierarchy;

public sealed class Truck : Vehicle
{
    private double _maxLoadCapacity { get; set; }

    public Truck(string maker, string model, int year, double maxLoadCapacity) : base(maker, model, year)
    {
        _maxLoadCapacity = maxLoadCapacity;
    }
}