using System;
using System.Collections.Generic;
using System.Text;

namespace Nop.Core.Domain.Hours
{
    public partial class ShopHoursList : BaseEntity
    {
        public TimeSpan ShopTime { get; set; }
    }
}
