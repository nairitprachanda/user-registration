﻿using System;

namespace User_Registration_Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the User Registration Problem!");
            ValidateUserRegistration validateUserRegistration = new ValidateUserRegistration();
            Console.WriteLine("Enter your first name : ");
            string firstName = Console.ReadLine();
            bool firstNameResult = validateUserRegistration.ValidateFirstName(firstName);
            validateUserRegistration.PrintResult(firstNameResult);
            Console.WriteLine("Enter your last name : ");
            string lastName = Console.ReadLine();
            bool lastNameResult = validateUserRegistration.ValidateLastName(lastName);
            validateUserRegistration.PrintResult(lastNameResult);
            Console.WriteLine("Enter your email : ");
            string eMail = Console.ReadLine();
            bool eMailResult = validateUserRegistration.ValidateEmail(eMail);
            validateUserRegistration.PrintResult(eMailResult);
            Console.WriteLine("Enter your mobile number : ");
            string mobileNo = Console.ReadLine();
            bool mobileNoResult = validateUserRegistration.ValidateMobileNo(mobileNo);
            validateUserRegistration.PrintResult(mobileNoResult);
            Console.WriteLine("Enter your password : ");
            string password = Console.ReadLine();
            bool passwordResult = validateUserRegistration.ValidatePassword(password);
            validateUserRegistration.PrintResult(passwordResult);
            Console.WriteLine("Checking for sample mails :");
            foreach (string mail in validateUserRegistration.GetList())
            {
                Console.Write(mail + " : ");
                validateUserRegistration.PrintResult(validateUserRegistration.ValidateEmail2(mail));
            }
        }
    }
}
