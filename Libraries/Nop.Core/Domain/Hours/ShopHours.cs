using System;
using System.Collections.Generic;
using System.Text;

namespace Nop.Core.Domain.Hours
{
    public partial class ShopHours : BaseEntity
    {
        public string Weekday { get; set; }
        public int StartHourId { get; set; }
        public int EndHourID { get; set; }
        public bool Closed { get; set; }
    }
}
