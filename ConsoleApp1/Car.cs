namespace ConsoleApp1;

public class Car : Vehicle
{
    private string _manufacturer;
    private string _model;
    private int _horsepower;
    private double _rentPerHour;


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

    public double RentPerHour
    {
        get => _rentPerHour;
        set => _rentPerHour = Math.Round(value, 2);
    }

    public Car(int numberOfWheels, string color, string manufacturer, string model, int horsepower, double rentPerHour)
        : base(numberOfWheels, color)
    {
        Manufacturer = manufacturer;
        Model = model;
        Horsepower = horsepower;
        RentPerHour = rentPerHour;
    }

    public override string ToString()
    {
        return $"Car with {NumberOfWheels} wheels, colored {Color}, manufacturer: {Manufacturer},\nmodel: {Model}, " +
               $"horsepower: {Horsepower}, cost for rent per hour: {RentPerHour}.";
    }
}