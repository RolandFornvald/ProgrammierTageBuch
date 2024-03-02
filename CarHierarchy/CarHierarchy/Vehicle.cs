using System.ComponentModel;

namespace CarHierarchy;

public class Vehicle
{
    private string _maker { get; set; }
    private string _model { get; set; }
    private int _year { get; set; }

    protected Vehicle(string maker, string model, int year)
    {
        _maker = maker;
        _model = model;
        _year = year;
    }
}