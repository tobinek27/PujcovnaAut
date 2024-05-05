using System;

namespace ConsoleApp1
{
    public class Car : Vehicle
    {
        private string _manufacturer;
        private string _model;
        private int _horsepower;
        private double _rentPerHour;

        /// <summary>
        /// Gets or sets the manufacturer of the car.
        /// </summary>
        /// <exception cref="ArgumentException">Thrown when the provided manufacturer is null or empty.</exception>
        public string Manufacturer
        {
            get => _manufacturer;
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException($"Invalid manufacturer: {value}");
                }

                _manufacturer = value;
            }
        }

        /// <summary>
        /// Gets or sets the model of the car.
        /// </summary>
        /// <exception cref="ArgumentException">Thrown when the provided model is null or empty.</exception>
        public string Model
        {
            get => _model;
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException($"Invalid model: {value}");
                }

                _model = value;
            }
        }

        /// <summary>
        /// Gets or sets the horsepower of the car.
        /// </summary>
        /// <exception cref="ArgumentException">Thrown when the provided horsepower is not positive.</exception>
        public int Horsepower
        {
            get => _horsepower;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException($"Invalid horsepower: {value}");
                }

                _horsepower = value;
            }
        }

        /// <summary>
        /// Gets or sets the rent per hour of the car.
        /// </summary>
        public double RentPerHour
        {
            get => _rentPerHour;
            set => _rentPerHour = Math.Round(value, 2);
        }

        /// <summary>
        /// Initializes a new instance of the Car class with the specified parameters.
        /// </summary>
        /// <param name="numberOfWheels">The number of wheels of the car.</param>
        /// <param name="color">The color of the car.</param>
        /// <param name="manufacturer">The manufacturer of the car.</param>
        /// <param name="model">The model of the car.</param>
        /// <param name="horsepower">The horsepower of the car.</param>
        /// <param name="rentPerHour">The rent per hour of the car.</param>
        public Car(int numberOfWheels, string color, string manufacturer, string model, int horsepower,
            double rentPerHour)
            : base(numberOfWheels, color)
        {
            Manufacturer = manufacturer;
            Model = model;
            Horsepower = horsepower;
            RentPerHour = rentPerHour;
        }

        /// <summary>
        /// Overrides the default ToString method to provide a string representation of the car's details.
        /// </summary>
        /// <returns>A string containing the number of wheels, color, manufacturer, model, horsepower, and rent per hour of the car.</returns>
        public override string ToString()
        {
            return
                $"Car with {NumberOfWheels} wheels, colored {Color}, manufacturer: {Manufacturer},\nmodel: {Model}, " +
                $"horsepower: {Horsepower}, cost for rent per hour: {RentPerHour}.";
        }
    }
}