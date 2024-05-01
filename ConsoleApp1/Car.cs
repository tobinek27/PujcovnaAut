namespace ConsoleApp1;

public class Car : Vehicle
{
    private string _manufacturer;
    private string _model;
    private int _horsepower;


    public string Manufacturer
    {
        get => _manufacturer;
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException($"invalid manufacturer: {value}");
            }

            _manufacturer = value;
        }
    }

    public string Model
    {
        get => _model;
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException($"invalid model: {value}");
            }

            _model = value;
        }
    }

    public int Horsepower
    {
        get => _horsepower;
        set
        {
            if (value <= 0)
            {
                throw new ArgumentException($"invalid horsepower: {value}");
            }

            _horsepower = value;
        }
    }

    public Car(int numberOfWheels, string color, string manufacturer, string model, int horsepower)
    : base(numberOfWheels, color)
    {
        Manufacturer = manufacturer;
        Model = model;
        Horsepower = horsepower;
    }

    public override string ToString()
    {
        return $"Car with {NumberOfWheels} wheels, colored {Color}, manufacturer: {Manufacturer}, model: {Model}," +
               $"horsepower: {Horsepower}";
    }
}