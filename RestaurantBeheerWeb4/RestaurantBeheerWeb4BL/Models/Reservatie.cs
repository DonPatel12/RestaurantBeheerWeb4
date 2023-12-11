using RestaurantBeheerWeb4BL.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantBeheerWeb4BL.Models
{
    public class Reservatie
    {
        public Reservatie(int id, Gebruiker gebruiker, Restaurant restaurant, DateTime datum, int aantalPersonen, int tafelNummer)
        {
            Id = id;
            _gebruiker = gebruiker;
            _restaurant = restaurant;
            Datum = datum;
            AantalPersonen = aantalPersonen;
            TafelNummer = tafelNummer;
        }
        private int _id;
        public int Id 
        {
            get { return _id; }
            set
            {
                if (value <= 0)
                {
                    throw new ReservatieException("Id moet groter zijn dan 0");
                }
                _id = value;
            }
        }
        private Gebruiker _gebruiker;
        public Gebruiker Gebruiker
        {
            get { return _gebruiker; }
            set
            {
                if (value == null)
                {
                    throw new ReservatieException("Gebruiker mag niet leeg zijn");
                }
                _gebruiker = value;
            }
        }
        private Restaurant _restaurant;
         
        private DateTime _datum;
        public DateTime Datum
        {
            get { return _datum; }
            set
            {
                if (value == null)
                {
                    throw new ReservatieException("Datum mag niet leeg zijn");
                }
                if (value.Minute != 0 && value.Minute != 30)
                {
                    throw new ReservatieException("Het reservatietijdstip moet een exact uur of een half uur zijn.");
                }
                _datum = value;
            }
        }
        private int _aantalPersonen;
        public int AantalPersonen
        {
            get { return _aantalPersonen; }
            set
            {
                if (value <= 0)
                {
                    throw new ReservatieException("Aantal personen moet groter zijn dan 0");
                }
                _aantalPersonen = value;
            }
        }
        private int _tafelNummer;
        public int TafelNummer
        {
            get { return _tafelNummer; }
            set
            {
                if (value <= 0)
                {
                    throw new ReservatieException("Tafel nummer moet groter zijn dan 0");
                }
                _tafelNummer = value;
            }
        }

    }
}
