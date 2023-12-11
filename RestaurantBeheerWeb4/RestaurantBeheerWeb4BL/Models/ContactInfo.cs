using RestaurantBeheerWeb4BL.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantBeheerWeb4BL.Models
{
    public class ContactInfo
    {
        private string _email;
        private string _telefoonNummer;

        public string Email
        {
            get { return _email; }
            set
            {
                if (string.IsNullOrWhiteSpace(value)) throw new ContactInfoException("Email kan niet leeg zijn");
                _email = value;
            }
        }
        public string TelefoonNummer 
        {
            get { return _telefoonNummer; }
            set
            {
                if (string.IsNullOrWhiteSpace(value)) throw new ContactInfoException("Telefoon nummer kan niet leeg zijn");
                _telefoonNummer = value;
            }
        }
        public Locatie Locatie { get; set; }

        public ContactInfo(string email, string telefoonNummer, Locatie locatie)
        {
            Email = email;
            TelefoonNummer = telefoonNummer;
            Locatie = locatie;
        }

    }
}
