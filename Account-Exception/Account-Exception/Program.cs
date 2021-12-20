using Account_Exception.Models;
using System;

namespace Account_Exception
{
    class Program
    {
        static void Main(string[] args)
        {

            Account account1 = new Account();
            try
            {
                account1.LogIn("aaaa", "bbbbbbbb");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
            
            
        }
    }
}
