using RestaurantBeheerWeb4BL.Interfaces;
using RestaurantBeheerWeb4BL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantBeheerWeb4DL.Repositories
{
    public class RestaurantRepository : IRestaurantRepository
    {
        private string connectionString;
        public RestaurantRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void AddRestaurant(Restaurant restaurant)
        {
            throw new NotImplementedException();
        }

        public void DeleteRestaurant(Restaurant restaurant)
        {
            throw new NotImplementedException();
        }

        public List<Restaurant> GetRestaurants()
        {
            throw new NotImplementedException();
        }

        public List<Restaurant> SearchRestaurants(string? location, string? keukentype)
        {
            throw new NotImplementedException();
        }

        public void UpdateRestaurant(Restaurant restaurant)
        {
            throw new NotImplementedException();
        }
    }
    
}
