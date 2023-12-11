using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantBeheerWeb4BL.Exceptions
{
    public class LocatieException : Exception
    {
        public LocatieException(string message) : base(message)
        {
        }

        public LocatieException(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}
