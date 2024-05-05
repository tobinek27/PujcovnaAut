namespace ConsoleApp1;

public class Rental
{
    /// <summary>
    /// Gets or sets the customer renting the car.
    /// </summary>
    public Customer Customer { get; set; }

    /// <summary>
    /// Gets or sets the car being rented.
    /// </summary>
    public Car Car { get; set; }

    /// <summary>
    /// Gets or sets the start date of the rental period.
    /// </summary>
    public DateTime RentalStartDate { get; set; }

    /// <summary>
    /// Gets or sets the end date of the rental period.
    /// </summary>
    public DateTime RentalEndDate { get; set; }


    /// <summary>
    /// Initializes a new instance of the Rental class with the specified parameters.
    /// </summary>
    /// <param name="customer">The customer renting the car.</param>
    /// <param name="car">The car being rented.</param>
    /// <param name="rentalStartDate">The start date of the rental period.</param>
    /// <param name="rentalEndDate">The end date of the rental period.</param>
    /// <exception cref="ArgumentNullException">Thrown when <paramref name="customer"/> or <paramref name="car"/> is null.</exception>
    /// <exception cref="ArgumentException">Thrown when rental start date is not before rental end date.</exception>
    public Rental(Customer customer, Car car, DateTime rentalStartDate, DateTime rentalEndDate)
    {
        Customer = customer ?? throw new ArgumentNullException(nameof(customer));
        Car = car ?? throw new ArgumentNullException(nameof(car));

        if (rentalStartDate >= rentalEndDate)
        {
            throw new ArgumentException("Rental start date must be before rental end date");
        }

        RentalStartDate = rentalStartDate;
        RentalEndDate = rentalEndDate;
    }

    /// <summary>
    /// Overrides the default ToString method to provide a string representation of the rental details.
    /// </summary>
    /// <returns>A string containing customer name, car details, and rental period.</returns>
    public override string ToString()
    {
        return
            $"Rental details:\nCustomer: {Customer.FirstName} {Customer.LastName}\nCar: {Car.Manufacturer} {Car.Model}\n" +
            $"rental period: {RentalStartDate:yyyy-MM-dd HH:mm:ss} to {RentalEndDate:yyyy-MM-dd HH:mm:ss}.";
    }

    /// <summary>
    /// Calculates the total cost of the rental based on the duration and the rent per hour of the car.
    /// </summary>
    /// <returns>The total cost of the rental.</returns>
    public double CountTheCost()
    {
        TimeSpan rentalDuration = RentalEndDate - RentalStartDate;
        double rentalHours = rentalDuration.TotalHours;
        double totalCost = rentalHours * Car.RentPerHour;
        totalCost = Math.Round(totalCost, 2);

        return totalCost;
    }
}