using System;
using System.Collections.Generic;
using System.Text;

namespace Account_Exception.Exceptions
{
    public class LogIn_Exception : Exception
    {
        public LogIn_Exception(string message):base(message)
        {
            
        }
    }
}
