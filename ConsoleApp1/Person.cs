namespace ConsoleApp1
{
    public class Person
    {
        private string _firstName;
        private string _lastName;
        private DateTime _birthdate;

        /// <summary>
        /// Gets or sets the first name of the person.
        /// </summary>
        /// <exception cref="ArgumentException">Thrown when the provided first name is null, empty, shorter than 3 characters, or longer than 32 characters.</exception>
        public string FirstName
        {
            get => _firstName;
            set
            {
                if (string.IsNullOrEmpty(value) || value.Length <= 2 || value.Length >= 32)
                {
                    throw new ArgumentException(
                        "First name must be no shorter than 3 characters and no longer than 32 characters");
                }

                _firstName = value;
            }
        }

        /// <summary>
        /// Gets or sets the last name of the person.
        /// </summary>
        /// <exception cref="ArgumentException">Thrown when the provided last name is null, empty, shorter than 3 characters, or longer than 32 characters.</exception>
        public string LastName
        {
            get => _lastName;
            set
            {
                if (string.IsNullOrEmpty(value) || value.Length <= 2 || value.Length >= 32)
                {
                    throw new ArgumentException(
                        "Last name must be no shorter than 3 characters and no longer than 32 characters");
                }

                _lastName = value;
            }
        }

        /// <summary>
        /// Gets or sets the birthdate of the person.
        /// </summary>
        /// <exception cref="ArgumentException">Thrown when the provided birthdate is before 1900 or not a valid date.</exception>
        public DateTime Birthdate
        {
            get => _birthdate;
            set
            {
                if (value.Year <= 1899 || value.Month < 1 || value.Month > 12 || value.Day < 1 || value.Day > 31)
                {
                    throw new ArgumentException($"Invalid date provided: {value:yyyy-MM-dd}");
                }

                _birthdate = value;
            }
        }

        /// <summary>
        /// Initializes a new instance of the Person class with the specified parameters.
        /// </summary>
        /// <param name="firstName">The first name of the person.</param>
        /// <param name="lastName">The last name of the person.</param>
        /// <param name="birthdate">The birthdate of the person.</param>
        public Person(string firstName, string lastName, DateTime birthdate)
        {
            FirstName = firstName;
            LastName = lastName;
            Birthdate = birthdate;
        }

        /// <summary>
        /// Overrides the default ToString method to provide a string representation of the person's details.
        /// </summary>
        /// <returns>A string containing the person's full name and date of birth.</returns>
        public override string ToString()
        {
            return $"Person's full name: {FirstName} {LastName}, date of birth: {Birthdate:yyyy-MM-dd}.";
        }

        /// <summary>
        /// Calculates the age of the person based on the current date.
        /// </summary>
        /// <returns>The age of the person.</returns>
        public int GetAge()
        {
            DateTime today = DateTime.Today;
            int age = today.Year - Birthdate.Year;

            // Adjust age if birthday has not occurred yet this year
            if (Birthdate.Date > today.AddYears(-age))
                age--;

            return age;
        }

        /// <summary>
        /// Promotes the person to a customer by generating an email and creating a new Customer object.
        /// </summary>
        /// <returns>A Customer object based on the person's details.</returns>
        public Customer PromoteToCustomer()
        {
            string email = $"{FirstName.ToLower()}.{LastName.ToLower()}@example.com";
            Customer customer = new Customer(FirstName, LastName, Birthdate, email, DateTime.Now);

            return customer;
        }
    }
}