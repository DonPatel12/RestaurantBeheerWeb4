using RestaurantBeheerWeb4BL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantBeheerWeb4BL.Interfaces
{
    public interface IReservatieRepository
    {
        void AddReservatie(Reservatie reservatie);
        void UpdateReservatie(Reservatie reservatie);
        void DeleteReservatie(Reservatie reservatie);
        List<Reservatie> GetReservaties();
        List<Reservatie> GetPersoonlijkReservaties(int klantId, string? datum);
    }
}
