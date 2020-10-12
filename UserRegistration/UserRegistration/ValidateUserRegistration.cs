﻿using System;
using System.Collections.Generic;
using System.Text;

namespace UserRegistration
{
    class ValidateUserRegistration
    {
        private static readonly string Regex_FirstName = "^[A-Z]{1}[a-z]{2,}$";
        public bool ValidateFirstName(string FN)
        {
            return Regex.IsMatch(FN, Regex_FirstName);
        }
        public void PrintResult(bool result)
        {
            if (result)
            {
                Console.WriteLine("Valid name");
            }
            else
            {
                Console.WriteLine("Invalid name");
            }
        }
    }
}


