// ReSharper disable StyleCop.SA1600
// ReSharper disable StyleCop.SA1516
namespace WizardDemo.Classes
{
    /// <summary>
    /// The user details.
    /// </summary>
    public class UserDetails
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserDetails"/> class.
        /// </summary>
        /// <param name="firstName">
        /// The first name.
        /// </param>
        /// <param name="lastName">
        /// The last name.
        /// </param>
        /// <param name="email">
        /// The email.
        /// </param>
        public UserDetails(string firstName, string lastName, string email)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Email = email;
        }

        public string FirstName { get; }
        public string LastName { get; }
        public string Email { get;  }
    }
}