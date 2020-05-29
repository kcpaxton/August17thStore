using Nop.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nop.Plugin.Widgets.TimeSlots.Domain
{
    public partial class OrderTimeSlots : BaseEntity
    { 
        public TimeSpan ReservationTime { get; set; }

        public string FriendlyName { get; set; }
        public bool Available { get; set; }

        public int NumberOfOrdersBooked { get; set; }

        public int MaxNumberOfOrders { get; set; }
    }
}
