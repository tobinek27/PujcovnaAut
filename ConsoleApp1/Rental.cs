namespace ConsoleApp1;

public class Rental
{
    public Customer Customer { get; set; }
    public Car Car { get; set; }
    public DateTime RentalStartDate { get; set; }
    public DateTime RentalEndDate { get; set; }

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

    public override string ToString()
    {
        return
            $"Rental details:\nCustomer: {Customer.FirstName} {Customer.LastName}\nCar: {Car.Manufacturer} {Car.Model}\n" +
            $"rental period: {RentalStartDate:yyyy-MM-dd HH:mm:ss} to {RentalEndDate:yyyy-MM-dd HH:mm:ss}.";
    }

    public double CountTheCost()
    {
        TimeSpan rentalDuration = RentalEndDate - RentalStartDate;
        double rentalHours = rentalDuration.TotalHours;
        double totalCost = rentalHours * Car.RentPerHour;
        totalCost = Math.Round(totalCost, 2);

        return totalCost;
    }
}