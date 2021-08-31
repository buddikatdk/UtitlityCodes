using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class SeatNotAvailableException:Exception
{
    public string message;
    public SeatNotAvailableException(string message) : base(message)
    {
        this.message = message;
    }
}