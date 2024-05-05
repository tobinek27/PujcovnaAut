using System;

namespace ConsoleApp1
{
    public class Vehicle
    {
        private int _numberOfWheels;
        private string _color;

        /// <summary>
        /// Gets or sets the number of wheels of the vehicle.
        /// </summary>
        /// <exception cref="ArgumentException">Thrown when the provided number of wheels is not positive.</exception>
        public int NumberOfWheels
        {
            get => _numberOfWheels;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException($"Invalid number of wheels: {value}");
                }

                _numberOfWheels = value;
            }
        }

        /// <summary>
        /// Gets or sets the color of the vehicle.
        /// </summary>
        /// <exception cref="ArgumentException">Thrown when the provided color is null or empty.</exception>
        public string Color
        {
            get => _color;
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException($"Invalid color: {value}");
                }

                _color = value;
            }
        }

        /// <summary>
        /// Initializes a new instance of the Vehicle class with the specified parameters.
        /// </summary>
        /// <param name="numberOfWheels">The number of wheels of the vehicle.</param>
        /// <param name="color">The color of the vehicle.</param>
        public Vehicle(int numberOfWheels, string color)
        {
            NumberOfWheels = numberOfWheels;
            Color = color;
        }

        /// <summary>
        /// Overrides the default ToString method to provide a string representation of the vehicle's details.
        /// </summary>
        /// <returns>A string containing the number of wheels and the color of the vehicle.</returns>
        public override string ToString()
        {
            return $"Vehicle with {NumberOfWheels} wheels, colored {Color}.";
        }
    }
}