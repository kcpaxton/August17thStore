using System;
using System.Collections.Generic;
using System.Text;
using Nop.Core.Data;
using Nop.Plugin.Widgets.TimeSlots.Domain;
using System.Linq;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Nop.Plugin.Widgets.TimeSlots.Services
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

            var query = from ts in times
                        where ts.Available = true
                        select ts.FriendlyName;
            return query.ToList();
        }
    }
}
