namespace ConsoleApp1;

using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        string firstName = "John";
        string lastName = "Doe";
        DateTime birthdate = DateTime.Parse("2001-06-06");

        Person testPerson = new Person(firstName, lastName, birthdate);
        Console.WriteLine(testPerson);

        string email = "johndoe@johndoe.com";
        DateTime registrationDate = DateTime.Parse("2001-12-21");
        Customer testCustomer = new Customer(firstName, lastName, birthdate, email, registrationDate);
        Console.WriteLine(testCustomer);

        string color = "pink";
        int numberOfWheels = 4;
        Vehicle testVehicle = new Vehicle(numberOfWheels, color);
        Console.WriteLine(testVehicle);

        List<Person> personList = new List<Person>
        {
            new Person("John", "Smith", new DateTime(1985, 7, 15)),
            new Person("Emily", "Johnson", new DateTime(1990, 4, 23)),
            new Person("Michael", "Williams", new DateTime(1978, 11, 3)),
            new Person("Sophia", "Brown", new DateTime(1989, 9, 8))
        };

        List<Customer> customerList = new List<Customer>
        {
            new Customer("Alice", "Smith", new DateTime(1990, 5, 20), "alice@example.com", new DateTime(2023, 1, 15)),
            new Customer("Bob", "Johnson", new DateTime(1985, 9, 10), "bob@example.com", new DateTime(2022, 11, 30)),
            new Customer("Charlie", "Williams", new DateTime(1978, 3, 25), "charlie@example.com",
                new DateTime(2024, 3, 5)),
            new Customer("Diana", "Brown", new DateTime(1995, 11, 8), "diana@example.com", new DateTime(2023, 8, 12))
        };

        List<Vehicle> vehicleList = new List<Vehicle>
        {
            new Vehicle(4, "Red"),
            new Vehicle(2, "Black"),
            new Vehicle(4, "Blue"),
            new Vehicle(3, "Green")
        };

        List<Car> carList = new List<Car>
        {
            new Car(4, "Red", "Toyota", "Camry", 200, 5.751),
            new Car(4, "Black", "Honda", "Civic", 180, 7.515),
            new Car(4, "Blue", "Ford", "Mustang", 300, 44.997),
            new Car(4, "Green", "Chevrolet", "Corvette", 450, 55.751)
        };

        string dateString = "2024-05-30 15:30:00";
        DateTime rentalEndDate = DateTime.ParseExact(dateString, "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture);
        Rental testRental = new Rental(customerList[0], carList[0], DateTime.Now, rentalEndDate);
        Console.WriteLine(testRental);

        // test aaa
        string dateStringg = "2024-05-30 15:30:00";
        DateTime rentalEndDatee = DateTime.ParseExact(dateStringg, "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture);

        // Create instances of Customer and Car
        Customer customer = new Customer("John", "Doe", new DateTime(1990, 5, 15), "john.doe@example.com",
            new DateTime(2020, 1, 1));
        Car carr = new Car(4, "Red", "Toyota", "Corolla", 150, 25.50);

        // Use the appropriate constructor
        Rental testRentall = new Rental(customer, carr, DateTime.Now, rentalEndDatee);
        Console.WriteLine("AAAA");
        Console.WriteLine(testRental);
        Console.WriteLine("AAAA");
        
        foreach (var car in carList)
        {
            Console.WriteLine(car);
        }

        DateTime testicek1datetime = new DateTime(2024, 4, 1);
        DateTime testicek2datetime = new DateTime(2024, 5, 1);
        Console.WriteLine(testicek2datetime >= testicek1datetime);
        List<Rental> rentalList = new List<Rental>
        {
            // Rentals with specified end dates
            new Rental(
                new Customer("John", "Doe", new DateTime(1990, 5, 15), "john.doe@example.com",
                    new DateTime(2020, 1, 1)),
                new Car(4, "Red", "Toyota", "Corolla", 150, 25.50),
                new DateTime(2024, 4, 1),
                new DateTime(2024, 4, 10)
            ),
            new Rental(
                new Customer("Jane", "Smith", new DateTime(1985, 8, 20), "jane.smith@example.com",
                    new DateTime(2018, 6, 10)),
                new Car(4, "Blue", "Honda", "Civic", 120, 20.75),
                new DateTime(2024, 3, 15),
                new DateTime(2024, 3, 25)
            ),
            new Rental(
                new Customer("Alice", "Johnson", new DateTime(1995, 3, 10), "alice.johnson@example.com",
                    new DateTime(2022, 9, 20)),
                new Car(4, "Black", "Ford", "Mustang", 300, 40.00),
                new DateTime(2024, 5, 5),
                new DateTime(2024, 5, 15)
            ),
            new Rental(
                new Customer("Bob", "Brown", new DateTime(1980, 12, 25), "bob.brown@example.com",
                    new DateTime(2016, 7, 3)),
                new Car(4, "Silver", "Chevrolet", "Camaro", 280, 35.25),
                new DateTime(2024, 4, 20),
                new DateTime(2024, 5, 5)
            ),
            new Rental(
                new Customer("Emily", "Wilson", new DateTime(1992, 6, 5), "emily.wilson@example.com",
                    new DateTime(2021, 11, 12)),
                new Car(4, "White", "Tesla", "Model S", 450, 50.75),
                new DateTime(2024, 5, 1),
                new DateTime(2024, 5, 10)
            ),
            new Rental(
                new Customer("Michael", "Lee", new DateTime(1988, 9, 30), "michael.lee@example.com",
                    new DateTime(2019, 4, 28)),
                new Car(4, "Gray", "BMW", "3 Series", 220, 30.00),
                new DateTime(2024, 4, 25),
                new DateTime(2024, 5, 15)
            ),
            new Rental(
                new Customer("Sarah", "Garcia", new DateTime(1983, 7, 18), "sarah.garcia@example.com",
                    new DateTime(2020, 3, 8)),
                new Car(4, "Red", "Audi", "A4", 200, 28.50),
                new DateTime(2024, 5, 5),
                new DateTime(2024, 5, 20)
            ),
            new Rental(
                new Customer("David", "Martinez", new DateTime(1975, 11, 8), "david.martinez@example.com",
                    new DateTime(2015, 5, 20)),
                new Car(4, "Silver", "Mercedes-Benz", "C-Class", 280, 35.00),
                new DateTime(2024, 4, 28),
                new DateTime(2024, 5, 10)
            ),
            new Rental(
                new Customer("Laura", "Rodriguez", new DateTime(1990, 2, 14), "laura.rodriguez@example.com",
                    new DateTime(2022, 1, 10)),
                new Car(4, "Blue", "Volkswagen", "Golf", 150, 22.00),
                new DateTime(2024, 5, 2),
                new DateTime(2024, 5, 12)
            ),
            new Rental(
                new Customer("James", "Taylor", new DateTime(1986, 4, 30), "james.taylor@example.com",
                    new DateTime(2021, 7, 5)),
                new Car(4, "Black", "Hyundai", "Elantra", 130, 18.50),
                new DateTime(2024, 5, 3),
                new DateTime(2024, 5, 13)
            )
        };
        foreach (var rental in rentalList)
        {
            Console.WriteLine(rental);
        }
    }
}