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
    public class RestaurantService
    {
        IRestaurantRepository repo;
        public RestaurantService(IRestaurantRepository repo)
        {
            this.repo = repo;
        }

        public void AddRestaurant(Restaurant restaurant)
        {
            try
            {
                repo.AddRestaurant(restaurant);
            }
            catch (Exception ex)
            {
                throw new RestaurantServiceException("RestaurantService: AddRestaurant() --> " + ex.Message);
            }
        }

        public void UpdateRestaurant(Restaurant restaurant)
        {
            try
            {
                repo.UpdateRestaurant(restaurant);
            }
            catch (Exception ex)
            {
                throw new RestaurantServiceException("RestaurantService: UpdateRestaurant() --> " + ex.Message);
            }
        }

        public void DeleteRestaurant(Restaurant restaurant)
        {
            try
            {
                repo.DeleteRestaurant(restaurant);
            }
            catch (Exception ex)
            {
                throw new RestaurantServiceException("RestaurantService: DeleteRestaurant() --> " + ex.Message);
            }
        }

        public List<Restaurant> GetRestaurants()
        {
            try
            {
                return repo.GetRestaurants();
            }
            catch (Exception ex)
            {
                throw new RestaurantServiceException("RestaurantService: GetRestaurants() --> " + ex.Message);
            }
        }

        public List<Restaurant> SearchRestaurants(string? location, string? keukentype)
        {
            try
            {
                return repo.SearchRestaurants(location, keukentype);
            }
            catch (Exception ex)
            {
                throw new RestaurantServiceException("RestaurantService: SearchRestaurants() --> " + ex.Message);
            }
        }
    }
}
