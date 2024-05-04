namespace ConsoleApp1;

using System.Globalization;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List<Person> personList = new List<Person>
        {
            new("John", "Smith", new DateTime(1985, 7, 15)),
            new("Emily", "Johnson", new DateTime(1990, 4, 23)),
            new("Michael", "Williams", new DateTime(1978, 11, 3)),
            new("Sophia", "Brown", new DateTime(1989, 9, 8)),
            new("Alice", "Smith", new DateTime(1990, 5, 20)),
            new("Bob", "Johnson", new DateTime(1985, 9, 10)),
            new("Charlie", "Williams", new DateTime(1978, 3, 25)),
            new("Diana", "Brown", new DateTime(1995, 11, 8)),
            new("Joaquin", "Actor", new DateTime(1975, 12, 5)),
        };

        List<Customer> customerList = new List<Customer>
        {
            personList[0].PromoteToCustomer(),
            personList[1].PromoteToCustomer(),
            personList[2].PromoteToCustomer(),
            personList[3].PromoteToCustomer(),
            personList[4].PromoteToCustomer()
        };

        List<Vehicle> vehicleList = new List<Vehicle>
        {
            new(4, "Red"),
            new(2, "Black"),
            new(4, "Blue"),
            new(3, "Green")
        };

        List<Car> carList = new List<Car>
        {
            new(4, "Red", "Toyota", "Camry", 200, 5.751),
            new(4, "Black", "Honda", "Civic", 180, 7.515),
            new(4, "Blue", "Ford", "Mustang", 300, 44.997),
            new(4, "Green", "Chevrolet", "Corvette", 450, 55.751),
            new(4, "Yellow", "Volkswagen", "Golf", 200, 35.678),
            new(4, "Gray", "Audi", "A4", 220, 45.123),
            new(4, "Orange", "Subaru", "Outback", 190, 30.987),
            new(4, "Purple", "Mercedes-Benz", "C-Class", 240, 55.321),
            new(4, "Yellow", "Lamborghini", "Hurracan", 420, 130.25),
            new(4, "Red", "Škoda", "Fabia", 130, 15.264),
            new(4, "White", "Toyota", "Corolla", 180, 10.5),
            new(4, "Silver", "Honda", "Accord", 190, 12.75),
            new(4, "Black", "Ford", "Fusion", 170, 9.99),
            new(4, "Blue", "Chevrolet", "Malibu", 200, 14.99),
            new(4, "Red", "Volkswagen", "Jetta", 170, 11.99),
            new(4, "Gray", "Audi", "Q5", 250, 35.99),
            new(4, "Orange", "Subaru", "Legacy", 200, 17.99),
            new(4, "Purple", "Mercedes-Benz", "E-Class", 280, 50.99),
            new(4, "Yellow", "Lamborghini", "Aventador", 700, 299.99),
            new(4, "Red", "Škoda", "Octavia", 150, 20.5)
        };

        foreach (var car in carList)
        {
            Console.WriteLine(car);
        }

        List<Rental> rentalList = new List<Rental>
        {
            new Rental(
                customerList[0],
                carList[7],
                new DateTime(2024, 4, 1),
                new DateTime(2024, 4, 10)
            ),
            new Rental(
                customerList[1],
                carList[5],
                new DateTime(2024, 3, 15),
                new DateTime(2024, 3, 25)
            ),
            new Rental(
                customerList[4],
                carList[6],
                new DateTime(2024, 5, 5),
                new DateTime(2024, 5, 15)
            ),
            new Rental(
                customerList[3],
                carList[6],
                new DateTime(2024, 4, 20),
                new DateTime(2024, 5, 5)
            ),
            new Rental(
                customerList[3],
                carList[5],
                new DateTime(2024, 5, 1),
                new DateTime(2024, 5, 10)
            ),
            new Rental(
                customerList[2],
                carList[3],
                new DateTime(2024, 4, 25),
                new DateTime(2024, 5, 15)
            ),
            new Rental(
                customerList[4],
                carList[0],
                new DateTime(2024, 5, 5),
                new DateTime(2024, 5, 20)
            ),
            new Rental(
                customerList[3],
                carList[2],
                new DateTime(2024, 4, 28),
                new DateTime(2024, 5, 10)
            ),
            new Rental(
                customerList[4],
                carList[3],
                new DateTime(2024, 5, 2),
                new DateTime(2024, 5, 12)
            ),
            new Rental(
                customerList[2],
                carList[1],
                new DateTime(2024, 5, 3),
                new DateTime(2024, 5, 13)
            ),
            new Rental(
                customerList[0],
                carList[8],
                new DateTime(2024, 5, 10),
                new DateTime(2024, 5, 20)
            ),
            new Rental(
                customerList[1],
                carList[9],
                new DateTime(2024, 5, 15),
                new DateTime(2024, 5, 25)
            ),
            new Rental(
                customerList[3],
                carList[10],
                new DateTime(2024, 5, 3),
                new DateTime(2024, 5, 13)
            ),
            new Rental(
                customerList[2],
                carList[11],
                new DateTime(2024, 5, 7),
                new DateTime(2024, 5, 17)
            ),
            new Rental(
                customerList[4],
                carList[12],
                new DateTime(2024, 5, 12),
                new DateTime(2024, 5, 22)
            ),
            new Rental(
                customerList[1],
                carList[13],
                new DateTime(2024, 5, 18),
                new DateTime(2024, 5, 28)
            ),
            new Rental(
                customerList[0],
                carList[14],
                new DateTime(2024, 5, 24),
                new DateTime(2024, 6, 3)
            ),
            new Rental(
                customerList[2],
                carList[15],
                new DateTime(2024, 5, 30),
                new DateTime(2024, 6, 9)
            ),
            new Rental(
                customerList[4],
                carList[17],
                new DateTime(2024, 6, 5),
                new DateTime(2024, 6, 15)
            ),
            new Rental(
                customerList[3],
                carList[17],
                new DateTime(2024, 6, 11),
                new DateTime(2024, 6, 21)
            ),
            new Rental(
                customerList[1],
                carList[17],
                new DateTime(2024, 6, 17),
                new DateTime(2024, 6, 27)
            ),
            new Rental(
                customerList[0],
                carList[17],
                new DateTime(2024, 6, 23),
                new DateTime(2024, 7, 3)
            )
        };


        foreach (var rental in rentalList)
        {
            Console.WriteLine(rental);
        }

        foreach (var person in customerList)
        {
            Console.WriteLine(person.GetAge());
        }

        foreach (var rental in rentalList)
        {
            Console.WriteLine(rental.CountTheCost());
        }


        GetNonCustomers(personList, customerList);
        GetAvailableCarsForRent(carList, rentalList);
        GetBestSellingCars(carList, rentalList);
    }

    private static void GetAvailableCarsForRent(List<Car> carList, List<Rental> rentalList)
    {
        var availableCars = from car in carList
            join rental in rentalList
                on car equals rental.Car into gj
            from rental in gj.DefaultIfEmpty()
            where rental == null
            select car;

        List<Car> availableCarsList = availableCars.ToList();

        Console.WriteLine("Cars that are up for rent:");
        foreach (var car in availableCarsList)
        {
            Console.WriteLine(car);
        }
    }

    private static void GetNonCustomers(List<Person> personList, List<Customer> customerList)
    {
        var nonCustomers = from person in personList
            where !customerList.Any(customer =>
                customer.FirstName == person.FirstName && customer.LastName == person.LastName)
            select person;

        List<Person> nonCustomersList = nonCustomers.ToList();

        Console.WriteLine("People who are not yet Customers:");
        foreach (var person in nonCustomersList)
        {
            Console.WriteLine(person);
        }
    }

    private static void GetBestSellingCars(List<Car> carList, List<Rental> rentalList)
    {
        var soldCars = from car in carList
            join rental in rentalList
                on car equals rental.Car into carRentals
            let rentalCount = carRentals.Count()
            orderby rentalCount descending, car.RentPerHour descending
            select (car, rentalCount);

        List<(Car car, int rentalCount)> soldCarsList = soldCars.Take(3).ToList();

        Console.WriteLine("The three best-sellers:");
        foreach (var (car, rentalCount) in soldCarsList)
        {
            Console.WriteLine(
                $"Car: {car.Manufacturer} {car.Model}, cost of rent/hr: {car.RentPerHour}, rental Count: {rentalCount}");
        }
    }

    /*private static void GetBestSellingCars(List<Car> carList, List<Rental> rentalList)
    {
        var soldCars = from car in carList
            join rental in rentalList
                on car equals rental.Car into carRentals
            let rentalCount = carRentals.Count()
            orderby rentalCount descending
            select (car, rentalCount);

        List<(Car car, int rentalCount)> soldCarsList = soldCars.Take(3).ToList();

        Console.WriteLine("The three best-sellers:");
        foreach (var (car, rentalCount) in soldCarsList)
        {
            Console.WriteLine($"Car: {car.Manufacturer} {car.Model}, Rental Count: {rentalCount}");
        }
    }*/
}