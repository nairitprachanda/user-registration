using System;

namespace UserRegistration
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the User Registration Problem!");
            ValidateUserRegistration validateUserRegistration = new ValidateUserRegistration();
            Console.WriteLine("Enter your first name: ");
            string firstName = Console.ReadLine();
            bool firstNameResult = validateUserRegistration.ValidateFirstName(firstName);
            validateUserRegistration.PrintResult(firstNameResult);
        }
    }
}
