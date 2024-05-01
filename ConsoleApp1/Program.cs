namespace ConsoleApp1;


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
            new Customer("Charlie", "Williams", new DateTime(1978, 3, 25), "charlie@example.com", new DateTime(2024, 3, 5)),
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
            new Car(4, "Red", "Toyota", "Camry", 200),
            new Car(4, "Black", "Honda", "Civic", 180),
            new Car(4, "Blue", "Ford", "Mustang", 300),
            new Car(4, "Green", "Chevrolet", "Corvette", 450)
        };

    }
}