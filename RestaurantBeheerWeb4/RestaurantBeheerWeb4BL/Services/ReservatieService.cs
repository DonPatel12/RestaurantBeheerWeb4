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
    public class ReservatieService
    {
        IReservatieRepository repo;

        public ReservatieService(IReservatieRepository repo)
        {
            this.repo = repo;
        }

        public void AddReservatie(Reservatie reservatie)
        {
            try
            {                 repo.AddReservatie(reservatie);
                       }
            catch (Exception ex)
            {
                throw new ReservatieServiceException("ReservatieService: AddReservatie() --> " + ex.Message);
            }
        }

        public void UpdateReservatie(Reservatie reservatie)
        {
            try
            {
                repo.UpdateReservatie(reservatie);
            }
            catch (Exception ex)
            {
                throw new ReservatieServiceException("ReservatieService: UpdateReservatie() --> " + ex.Message);
            }
        }

        public void DeleteReservatie(Reservatie reservatie)
        {
            try
            {
                repo.DeleteReservatie(reservatie);
            }
            catch (Exception ex)
            {
                throw new ReservatieServiceException("ReservatieService: DeleteReservatie() --> " + ex.Message);
            }

        }

        public List<Reservatie> GetReservaties()
        {
            try
            {
                return repo.GetReservaties();
            }
            catch (Exception ex)
            {
                throw new ReservatieServiceException("ReservatieService: GetReservaties() --> " + ex.Message);
            }
        }
        public List<Reservatie> GetPersoonlijkReservaties(int klantId, string? datum)
        {
            try
            {
                return repo.GetPersoonlijkReservaties(klantId, datum);
            }
            catch (Exception ex)
            {
                throw new ReservatieServiceException("ReservatieService: GetPersoonlijkReservaties() --> " + ex.Message);
            }
        }
    }
}
