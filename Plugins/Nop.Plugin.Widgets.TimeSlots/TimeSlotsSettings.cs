using Nop.Core.Configuration;

namespace Nop.Plugin.Widgets.TimeSlots
{
    public class TimeSlotsSettings : ISettings
    {
        public int MaximumOrdersPerTimeSlot { get; set; }
    }
}