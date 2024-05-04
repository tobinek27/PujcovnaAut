namespace ConsoleApp1;

public class Vehicle
{
    private int _numberOfWheels;
    private string _color;


    public int NumberOfWheels
    {
        get => _numberOfWheels;
        set
        {
            if (value <= 0)
            {
                throw new ArgumentException($"invalid number of wheels: {value}");
            }

            _numberOfWheels = value;
        }
    }

    public string Color
    {
        get => _color;
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException($"invalid color: {value}");
            }

            _color = value;
        }
    }

    public Vehicle(int numberOfWheels, string color)
    {
        NumberOfWheels = numberOfWheels;
        Color = color;
    }

    public override string ToString()
    {
        return $"vehicle with {NumberOfWheels} wheels, colored {Color}";
    }
}