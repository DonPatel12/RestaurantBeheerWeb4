using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantBeheerWeb4BL.Exceptions
{
    public class GebruikerServiceException : Exception
    {
        public GebruikerServiceException()
        {
        }

        public GebruikerServiceException(string message)
            : base(message)
        {
        }

        public GebruikerServiceException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
