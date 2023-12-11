using RestaurantBeheerWeb4BL.Interfaces;
using RestaurantBeheerWeb4BL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantBeheerWeb4DL.Repositories
{
    public class ReservatieRepository : IReservatieRepository
    {
        private string connectionString;
        public ReservatieRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void AddReservatie(Reservatie reservatie)
        {
            throw new NotImplementedException();
        }

        public void DeleteReservatie(Reservatie reservatie)
        {
            throw new NotImplementedException();
        }

        public List<Reservatie> GetPersoonlijkReservaties(int klantId, string? datum)
        {
            throw new NotImplementedException();
        }

        public List<Reservatie> GetReservaties()
        {
            throw new NotImplementedException();
        }

        public void UpdateReservatie(Reservatie reservatie)
        {
            throw new NotImplementedException();
        }
    }
}
