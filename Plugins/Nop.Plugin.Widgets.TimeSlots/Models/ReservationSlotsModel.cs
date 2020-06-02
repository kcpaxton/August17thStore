using System;
using System.Collections.Generic;
using System.Text;
using Nop.Web.Framework.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Nop.Core.Domain.ReservationTimeSlots;

namespace Nop.Plugin.Widgets.TimeSlots.Models
{
    public class ReservationSlotsModel : BaseNopModel
    {
        public List<OrderTimeSlots> ListOfTimeSlots { get; set; }

        public IList<string> ListOfTimes { get; set; }

        public string ChosenTime { get; set; }
    }
}