﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
namespace User_Registration_Problem
{
    class ValidateUserRegistration
    {
        private List<string> sampleMails = new List<string>()
        {
            "abc@yahoo.com",
            "abc-100@yahoo.com",
            "abc-100@yahoo.com",
            "abc.100@yahoo.com",
            "abc111@abc.com",
            "abc-100@abc.net",
            "abc.100@abc.com.au",
            "abc@1.com",
            "abc@gmail.com.com",
            "abc+100@gmail.com"
        };
        private static readonly string Regex_FirstName = "^[A-Z]{1}[a-z]{2,}$";
        private static readonly string Regex_LastName = "^[A-Z]{1}[a-z]{2,}$";
        private static readonly string Regex_Email = "^[0-9a-zA-Z]{1,}([._+-][0-9a-zA-Z]{0,})*[@][0-9a-zA-Z]{1,}.[a-zA-Z]{2,3}(.[a-zA-Z]{2,3})?$";
        private static readonly string Regex_MobileNo = "^[1-9]{1}[0-9]{1,2}[ ][1-9]{1}[0-9]{9}$";
        private static readonly string Regex_Password = "^(?=.*[0-9])(?=.*[A-Z])(?=[^!@#$%&+-.]*[!@#$%&+-.][^!@#$%&+-.]*$)[\\S]{8,}$";
        private static readonly string Regex_Email2 = "^[0-9a-zA-Z]{1,}([._+-][0-9a-zA-Z]{0,})*[@][0-9a-zA-Z]{1,}.[a-zA-Z]{2,3}(.[a-zA-Z]{2,3})?$";
        public bool ValidateFirstName(string FN)
        {
            return Regex.IsMatch(FN, Regex_FirstName);
        }
        public bool ValidateLastName(string LN)
        {
            return Regex.IsMatch(LN, Regex_LastName);
        }
        public bool ValidateEmail(string Email)
        {
            return Regex.IsMatch(Email, Regex_Email);
        }
        public bool ValidateMobileNo(string MobileNo)
        {
            return Regex.IsMatch(MobileNo, Regex_MobileNo);
        }
        public bool ValidatePassword(string Password)
        {
            return Regex.IsMatch(Password, Regex_Password);
        }
        public bool ValidateEmail2(string email)
        {
            return Regex.IsMatch(email, Regex_Email2);
        }
        public void PrintResult(bool result)
        {
            if (result)
            {
                Console.WriteLine("Valid.");
            }
            else
            {
                Console.WriteLine("Invalid.");
            }
        }
        public List<string> GetList()
        {
            return sampleMails;
        }
    }
}