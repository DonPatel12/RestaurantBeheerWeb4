using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantBeheerWeb4BL.Models
{
    public class Restaurant
    {
        public string Naam { get; set; }
        public int Postcode { get; set; }
        public string Gemeente { get; set; }            
        public string StraatNaam { get; set; }
        public int HuisNummer { get; set; }
        public string KeukenType { get; set; }
        public int TelefoonNummer { get; set; }
        public string Email { get; set; }


    }
}
