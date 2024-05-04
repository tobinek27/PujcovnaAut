namespace ConsoleApp1;

using System.Text.RegularExpressions;

public class Customer : Person
{
    private string _email;
    private DateTime _registrationDate;


    public string Email
    {
        get => _email;
        set
        {
            if (!IsValidEmail(value))
            {
                throw new ArgumentException($"invalid email address provided: {value}");
            }

            _email = value;
        }
    }

    public DateTime RegistrationDate
    {
        get => _registrationDate;
        set
        {
            if (value.Year <= 1899 || value.Month < 1 || value.Month > 12 || value.Day < 1 || value.Day > 31)
            {
                throw new ArgumentException($"invalid date provided: {value.ToString("yyyy-MM-dd")}");
            }

            _registrationDate = value;
        }
    }

    public Customer(string firstName, string lastName, DateTime birthdate, string email, DateTime registrationDate)
        : base(firstName, lastName, birthdate)
    {
        Email = email;
        RegistrationDate = registrationDate;
    }

    public override string ToString()
    {
        return $"customer's full name: {FirstName} {LastName}, date of birth: {Birthdate.ToString("yyyy-MM-dd")}, " +
               $"email: {Email} and registration date: {RegistrationDate.ToString("yyyy-MM-dd")}";
    }

    private bool IsValidEmail(string email)
    {
        // matches characters a-z, A-Z, 0-9 and some special characters
        // then a '@'
        // then a domain/subdomain: a-z A-Z 0-9
        // then a dot '.'
        // and at last, a no-less-than two character long extension
        string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
        return Regex.IsMatch(email, pattern);
    }
}