using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantBeheerWeb4BL.Exceptions
{
    public class ReservatieServiceException : Exception
    {
        public ReservatieServiceException()
        {
        }

        public ReservatieServiceException(string message)
            : base(message)
        {
        }

        public ReservatieServiceException(string message, Exception inner)
            : base(message, inner)
        {
        }
    
    
    }
}
