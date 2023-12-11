using RestaurantBeheerWeb4BL.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantBeheerWeb4BL.Models
{
    public class Locatie
    {
        public Locatie(string straatNaam, string huisNummer, int postcode, string gemeente)
        {
            StraatNaam = straatNaam;
            HuisNummer = huisNummer;
            Postcode = postcode;
            Gemeente = gemeente;
        }
        private string _straatNaam;
        public string StraatNaam
        {
            get { return _straatNaam; }
            set { if (string.IsNullOrWhiteSpace(value)) throw new LocatieException("Straatnaam kan niet leeg zijn");
                _straatNaam = value; }
        }
        private string _huisNummer;
        public string HuisNummer
        {
            get { return _huisNummer; }
            set
            {
                if (string.IsNullOrWhiteSpace(value)) throw new LocatieException("Huisnummer kan niet leeg zijn");
                _huisNummer = value;
            }
        }
        
        private int _postcode;
        public int Postcode 
        {
            get { return _postcode; }
            set
            {
                if (value < 1000 || value > 9999) throw new LocatieException("Postcode moet tussen 1000 en 9999 liggen");
                _postcode = value;
            }
        }
        private string _gemeente;
        public string Gemeente
        {
            get { return _gemeente; }
            set
            {
                if (string.IsNullOrWhiteSpace(value)) throw new LocatieException("Gemeente kan niet leeg zijn");
                _gemeente = value;
            }
        }

        

    }
}
