namespace ConsoleApp1;

public class Person
{
    private string _firstName;
    private string _lastName;
    private DateTime _birthdate;


    public string FirstName
    {
        get => _firstName;
        set
        {
            if (string.IsNullOrEmpty(value) || value.Length <= 2 || value.Length >= 32)
            {
                throw new ArgumentException("first name must be no shorter than 3 characters" +
                                            ", and no longer than 32 characters");
            }

            _firstName = value;
        }
    }

    public string LastName
    {
        get => _lastName;
        set
        {
            if (string.IsNullOrEmpty(value) || value.Length <= 2 || value.Length >= 32)
            {
                throw new ArgumentException("last name must be no shorter than 3 characters" +
                                            ", and no longer than 32 characters");
            }

            _lastName = value;
        }
    }

    public DateTime Birthdate
    {
        get => _birthdate;
        set
        {
            if (value.Year <= 1899 || value.Month < 1 || value.Month > 12 || value.Day < 1 || value.Day > 31)
            {
                throw new ArgumentException($"invalid date provided: {value.ToString("yyyy-MM-dd")}");
            }

            _birthdate = value;
        }
    }

    public Person(string firstName, string lastName, DateTime birthdate)
    {
        FirstName = firstName;
        LastName = lastName;
        Birthdate = birthdate;
    }

    public override string ToString()
    {
        return $"person's full name: {FirstName} {LastName}, date of birth: {Birthdate.ToString("yyyy-MM-dd")}";
    }

    public int GetAge()
    {
        DateTime today = DateTime.Today;
        int age = today.Year - Birthdate.Year;

        // this checks if the birthday has already occured this year
        if (Birthdate.Date > today.AddYears(-age))
            age--;

        return age;
    }

    public Customer PromoteToCustomer()
    {
        string email = $"{FirstName.ToLower()}.{LastName.ToLower()}@example.com";
        Customer customer = new Customer(FirstName, LastName, Birthdate, email, DateTime.Now);

        return customer;
    }
}