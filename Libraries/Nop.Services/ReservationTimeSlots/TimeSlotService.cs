using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Nop.Core.Data;
using Nop.Core.Domain.ReservationTimeSlots;
using OfficeOpenXml.FormulaParsing.Excel.Functions.Text;

namespace Nop.Services.ReservationTimeSlots
{
    public partial class TimeSlotService : ITimeSlotService
    {
        #region fields
        private readonly IRepository<OrderTimeSlots> _timeSlotsRepository;
        #endregion
        #region ctor

        public TimeSlotService(IRepository<OrderTimeSlots> timeSlotsRepository)
        {
            _timeSlotsRepository = timeSlotsRepository;
        }
        #endregion
        public virtual List<OrderTimeSlots> GetAllTimeSlots()
        {
            var query = from ts in _timeSlotsRepository.Table
                        orderby ts.Id
                        select ts;
            var timeSlots = query.ToList();
            return timeSlots;
        }

        public virtual IList<string> GetAllTimes(List<OrderTimeSlots> times)
        {
            TimeSpan currentTime = DateTime.Now.TimeOfDay;
            TimeSpan fifteenMinutes = TimeSpan.FromMinutes(30);
            var modifiedTime = currentTime.Add(fifteenMinutes);
            var query = from ts in times
                        where ts.Available == true && ts.ReservationTime > modifiedTime
                        select ts.FriendlyName;
            return query.ToList();
        }
        public virtual OrderTimeSlots GetTimeSlotByTime(string pickupTime)
        {
            var query = from ts in _timeSlotsRepository.Table
                        where ts.FriendlyName == pickupTime
                        select ts;

            return query.FirstOrDefault();
        }

        public virtual void UpdatePickupTime(OrderTimeSlots orderTimeSlots)
        {
            if (orderTimeSlots == null)
                throw new ArgumentNullException(nameof(orderTimeSlots));

            orderTimeSlots.NumberOfOrdersBooked++;
            if (orderTimeSlots.NumberOfOrdersBooked == orderTimeSlots.MaxNumberOfOrders)
            {
                orderTimeSlots.Available = false;
            }
            _timeSlotsRepository.Update(orderTimeSlots);
        }
    }
}
