using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Mvc.Rendering;
using Nop.Plugin.Widgets.TimeSlots.Domain;

namespace Nop.Plugin.Widgets.TimeSlots.Services
{
    public partial interface ITimeSlotService
    {
        List<OrderTimeSlots> GetAllTimeSlots();

        IList<string> GetAllTimes(List<OrderTimeSlots> times);

    }
}
