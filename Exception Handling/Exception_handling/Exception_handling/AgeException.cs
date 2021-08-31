using System;
using System.Collections.Generic;
using System.Text;

namespace Exception_handling
{
    class AgeException : Exception
    {
        public string message;
        public AgeException(string message)
        {
            this.message = message;
        }
    }
}
