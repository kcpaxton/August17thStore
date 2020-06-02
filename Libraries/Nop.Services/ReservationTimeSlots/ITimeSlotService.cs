using System;
using System.Collections.Generic;
using System.Text;
using Nop.Core.Domain.ReservationTimeSlots;

namespace Nop.Services.ReservationTimeSlots
{
    public partial interface ITimeSlotService
    {
        List<OrderTimeSlots> GetAllTimeSlots();

        IList<string> GetAllTimes(List<OrderTimeSlots> times);

        OrderTimeSlots GetTimeSlotByTime(string pickupTime);
        void UpdatePickupTime(OrderTimeSlots orderTimeSlots);
    }
}
