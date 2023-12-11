using RestaurantBeheerWeb4BL.Exceptions;
using RestaurantBeheerWeb4BL.Interfaces;
using RestaurantBeheerWeb4BL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantBeheerWeb4BL.Services
{
    public class GebruikerService
    {
        private IGebruikerRepository repo;

        public GebruikerService(IGebruikerRepository repo)
        {
            this.repo = repo;
        }

        public void AddGebruiker(Gebruiker gebruiker)
        {
            try 
            {      
                

                repo.AddGebruiker(gebruiker);
            }
            catch (Exception ex)
            {
                throw new GebruikerServiceException("GebruikerService: AddGebruiker() --> " + ex.Message);
            }
            
        }

        public void UpdateGebruiker(Gebruiker gebruiker)
        {
            try
            {
                repo.UpdateGebruiker(gebruiker);
            } catch (Exception ex)
            {
                   throw new GebruikerServiceException("GebruikerService: UpdateGebruiker() --> " + ex.Message);
            }
        }

        public void DeleteGebruiker(int id)
        {
            try 
            {                 
                repo.DeleteGebruiker(id);
            }
            catch (Exception ex)
            {
                throw new GebruikerServiceException("GebruikerService: DeleteGebruiker() --> " + ex.Message);
            }
        }

        public List<Gebruiker> GetGebruikers()
        {
            try
            {
                return repo.GetGebruikers();
            }
            catch (Exception ex)
            {
                throw new GebruikerServiceException("GebruikerService: GetGebruikers() --> " + ex.Message);
            }
            
        }
    }
}
