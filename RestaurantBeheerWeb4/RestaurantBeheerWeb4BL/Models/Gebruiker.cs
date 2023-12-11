using RestaurantBeheerWeb4BL.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RestaurantBeheerWeb4BL.Model
{
    public class Gebruiker
    {
        public string GebruikersNaam { get; set; }
        public string Email { get; set; }
        public string TelefoonNummer { get; set; }
        public string LocatieId { get; set; }
        public int KlantNummer { get; private set; }

        public void SetName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new GebruikerException("Naam mag niet leeg zijn");
            }
            GebruikersNaam = name;
        }

        public void SetEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
            {
                throw new GebruikerException("E-mail mag niet leeg zijn");
            }

            // Eenvoudige regex voor een geldig e-mailadres
            string emailRegex = @"^[a-zA-Z0-9._-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,6}$";

            if (!Regex.IsMatch(email, emailRegex))
            {
                throw new GebruikerException("Ongeldig e-mailadres");
            }

            Email = email;
        }

        public void SetTelefoonNummer(string telefoonNumber)
        {
            if (string.IsNullOrWhiteSpace(telefoonNumber))
            {
                throw new GebruikerException("Telefoonnummer mag niet leeg zijn");
            }

            // Eenvoudige regex voor een geldig telefoonnummer (10 cijfers)
            string phoneRegex = @"^\d{10}$";

            if (!Regex.IsMatch(telefoonNumber, phoneRegex))
            {
                throw new GebruikerException("Ongeldig telefoonnummer");
            }

            TelefoonNummer = telefoonNumber;
        }

    }
}
