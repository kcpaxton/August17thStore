using Microsoft.AspNetCore.Mvc.Rendering;

namespace Nop.Core.Domain.HoursOfOperation
{
    public partial class ShopHours : BaseEntity
    {
        public string Weekday { get; set; }

        public System.TimeSpan StartHour { get; set; }

        public System.TimeSpan EndHour { get; set; }

        public bool Closed { get; set; }
    }
}
