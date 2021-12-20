using Account_Exception.Constants;
using Account_Exception.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Account_Exception.Models
{
    public class Account
    {
        public string Email { get; set; }
        public string Password { get; set; }


        
        public void LogIn(string email,string password)
        {
           
            if (password.Length < 6)
            {
               throw new LogIn_Exception(Messages.PasswordMessage);
            }
            else
            {
                Console.WriteLine("Login is Successful!");
            }

           
            

            
            
        }
    }
}
