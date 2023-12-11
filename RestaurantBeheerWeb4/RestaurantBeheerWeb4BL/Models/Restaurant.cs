using RestaurantBeheerWeb4BL.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantBeheerWeb4BL.Models
{
    public class Restaurant
    {
        

        public ContactInfo ContactInfo { get; set; }

        public Restaurant(string naam, string beschrijving, string keukenType, int tafel, ContactInfo contactInfo)
        {
            Naam = naam;
            Beschrijving = beschrijving;
            KeukenType = keukenType;
            Tafel = tafel;
            ContactInfo = contactInfo;
        }

        public Restaurant(int restaurantId, string naam, string beschrijving, string keukenType, int tafel, ContactInfo contactInfo) : this(naam, beschrijving, keukenType, tafel, contactInfo)
        {
            RestaurantId = restaurantId;
        }
        
        private string _naam;
        public string Naam
        {
            get { return _naam; }
            set
            {
                if (string.IsNullOrWhiteSpace(value)) throw new RestaurantException("Naam kan niet leeg zijn");
                _naam = value;
            }
        }

        private string _beschrijving;
        public string Beschrijving
        {
            get { return _beschrijving; }
            set
            {
                if (string.IsNullOrWhiteSpace(value)) throw new RestaurantException("Beschrijving kan niet leeg zijn");
                _beschrijving = value;
            }
        }

        private string _keukenType;
        public string KeukenType
        {
            get { return _keukenType; }
            set
            {
                if (string.IsNullOrWhiteSpace(value)) throw new RestaurantException("Keuken type kan niet leeg zijn");
                _keukenType = value;
            }
        }

        private int _tafel;
        public int Tafel
        {
            get { return _tafel; }
            set
            {
                if (value < 0) throw new RestaurantException("Aantal plaatsen kan niet negatief zijn");
                _tafel = value;
            }
        }

        public int RestaurantId 
        {
            get { return RestaurantId; }
            set
            {
                if (value <= 0) throw new RestaurantException("RestaurantId kan niet negatief zijn");
                RestaurantId = value;
            }
        }


    }
}
