using RestaurantBeheerWeb4BL.Interfaces;
using RestaurantBeheerWeb4BL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantBeheerWeb4DL.Repositories
{
    public class GebruikerRepository : IGebruikerRepository
    {
        private string connectionString;
        public GebruikerRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }
        public void AddGebruiker(Gebruiker gebruiker)
        {
            throw new NotImplementedException();
        }

        public void DeleteGebruiker(int id)
        {
            throw new NotImplementedException();
        }

        public List<Gebruiker> GetGebruikers()
        {
            throw new NotImplementedException();
        }

        public void UpdateGebruiker(Gebruiker gebruiker)
        {
            throw new NotImplementedException();
        }
    }
}
