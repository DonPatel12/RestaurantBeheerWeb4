using RestaurantBeheerWeb4BL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantBeheerWeb4BL.Interfaces
{
    public interface IGebruikerRepository
    {
        void AddGebruiker(Gebruiker gebruiker);
        void UpdateGebruiker(Gebruiker gebruiker);
        void DeleteGebruiker(int id);
        List<Gebruiker> GetGebruikers();

        

    }
}
