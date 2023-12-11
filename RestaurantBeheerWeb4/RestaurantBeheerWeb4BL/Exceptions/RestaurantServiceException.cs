using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantBeheerWeb4BL.Exceptions
{
    public class RestaurantServiceException : Exception
    {
        public RestaurantServiceException()
        {
        }

        public RestaurantServiceException(string message)
            : base(message)
        {
        }

        public RestaurantServiceException(string message, Exception inner)
            : base(message, inner)
        {
        }
    
    
    } 
}
