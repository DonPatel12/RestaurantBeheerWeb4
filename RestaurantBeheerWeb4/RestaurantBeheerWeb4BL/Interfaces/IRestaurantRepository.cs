using RestaurantBeheerWeb4BL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantBeheerWeb4BL.Interfaces
{
    public interface IRestaurantRepository
    {
        void AddRestaurant(Restaurant restaurant);
        void UpdateRestaurant(Restaurant restaurant);
        void DeleteRestaurant(Restaurant restaurant);
        List<Restaurant> GetRestaurants();
        List<Restaurant> SearchRestaurants(string? location, string? keukentype);
    }
}
