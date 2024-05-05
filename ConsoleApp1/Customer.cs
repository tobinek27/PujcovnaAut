using System;
using System.Text.RegularExpressions;

namespace ConsoleApp1
{
    public class Customer : Person
    {
        private string _email;
        private DateTime _registrationDate;

        /// <summary>
        /// Gets or sets the email address of the customer.
        /// </summary>
        /// <exception cref="ArgumentException">Thrown when the provided email address is not valid.</exception>
        public string Email
        {
            get => _email;
            set
            {
                if (!IsValidEmail(value))
                {
                    throw new ArgumentException($"Invalid email address provided: {value}");
                }

                _email = value;
            }
        }

        /// <summary>
        /// Gets or sets the registration date of the customer.
        /// </summary>
        /// <exception cref="ArgumentException">Thrown when the provided registration date is before 1900 or not a valid date.</exception>
        public DateTime RegistrationDate
        {
            get => _registrationDate;
            set
            {
                if (value.Year <= 1899 || value.Month < 1 || value.Month > 12 || value.Day < 1 || value.Day > 31)
                {
                    throw new ArgumentException($"Invalid date provided: {value:yyyy-MM-dd}");
                }

                _registrationDate = value;
            }
        }

        /// <summary>
        /// Initializes a new instance of the Customer class with the specified parameters.
        /// </summary>
        /// <param name="firstName">The first name of the customer.</param>
        /// <param name="lastName">The last name of the customer.</param>
        /// <param name="birthdate">The birthdate of the customer.</param>
        /// <param name="email">The email address of the customer.</param>
        /// <param name="registrationDate">The registration date of the customer.</param>
        public Customer(string firstName, string lastName, DateTime birthdate, string email, DateTime registrationDate)
            : base(firstName, lastName, birthdate)
        {
            Email = email;
            RegistrationDate = registrationDate;
        }

        /// <summary>
        /// Overrides the default ToString method to provide a string representation of the customer's details.
        /// </summary>
        /// <returns>A string containing the customer's full name, date of birth, email, and registration date.</returns>
        public override string ToString()
        {
            return $"Customer's full name: {FirstName} {LastName}, date of birth: {Birthdate:yyyy-MM-dd}, " +
                   $"email: {Email} and registration date: {RegistrationDate:yyyy-MM-dd}.";
        }

        /// <summary>
        /// Checks if the provided email address is valid.
        /// </summary>
        /// <param name="email">The email address to validate.</param>
        /// <returns>True if the email address is valid, otherwise false.</returns>
        private bool IsValidEmail(string email)
        {
            // Regex pattern to validate email address
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            return Regex.IsMatch(email, pattern);
        }
    }
}