namespace ConsoleApp1;

using System.Globalization;

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
            new(personList[0].FirstName, personList[0].LastName, personList[0].Birthdate, "john@example.com",
                new DateTime(2023, 1, 15)),
            new(personList[1].FirstName, personList[1].LastName, personList[1].Birthdate, "emily@example.com",
                new DateTime(2022, 11, 30)),
            new(personList[2].FirstName, personList[2].LastName, personList[2].Birthdate,
                "michael@example.com",
                new DateTime(2024, 3, 5)),
            new(personList[3].FirstName, personList[3].LastName, personList[3].Birthdate, "sophia@example.com",
                new DateTime(2023, 8, 12)),
            new(personList[4].FirstName, personList[4].LastName, personList[4].Birthdate, "alice@example.com",
                new DateTime(2024, 4, 21))
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
            new(4, "Purple", "Mercedes-Benz", "C-Class", 240, 55.321)
        };

        foreach (var car in carList)
        {
            Console.WriteLine(car);
        }

        List<Rental> rentalList = new List<Rental>
        {
            new(
                customerList[0],
                carList[7],
                new DateTime(2024, 4, 1),
                new DateTime(2024, 4, 10)
            ),
            new(
                customerList[1],
                carList[5],
                new DateTime(2024, 3, 15),
                new DateTime(2024, 3, 25)
            ),
            new(
                customerList[4],
                carList[6],
                new DateTime(2024, 5, 5),
                new DateTime(2024, 5, 15)
            ),
            new(
                customerList[5],
                carList[6],
                new DateTime(2024, 4, 20),
                new DateTime(2024, 5, 5)
            ),
            new(
                customerList[3],
                carList[5],
                new DateTime(2024, 5, 1),
                new DateTime(2024, 5, 10)
            ),
            new(
                customerList[2],
                carList[3],
                new DateTime(2024, 4, 25),
                new DateTime(2024, 5, 15)
            ),
            new(
                customerList[6],
                carList[0],
                new DateTime(2024, 5, 5),
                new DateTime(2024, 5, 20)
            ),
            new(
                customerList[7],
                carList[2],
                new DateTime(2024, 4, 28),
                new DateTime(2024, 5, 10)
            ),
            new(
                customerList[8],
                carList[3],
                new DateTime(2024, 5, 2),
                new DateTime(2024, 5, 12)
            ),
            new(
                customerList[9],
                carList[1],
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