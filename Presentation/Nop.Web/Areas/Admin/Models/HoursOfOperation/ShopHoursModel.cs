using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using Nop.Web.Framework.Models;
using Nop.Web.Framework.Mvc.ModelBinding;

namespace Nop.Web.Areas.Admin.Models.ShopHours
{
    public class ShopHoursModel : BaseNopEntityModel
    {
         
        public ShopHoursModel()
        {
            
        }

        #region properties
        [NopResourceDisplayName("Admin.Configuration.ShopHours.Weekday")]
        public string Weekday { get; set; }

        [NopResourceDisplayName("Admin.Configuration.ShopHours.StartHour")]
        public System.TimeSpan StartHour { get; set; }

        [NopResourceDisplayName("Admin.Configuration.ShopHours.EndHour")]
        public System.TimeSpan EndHour { get; set; }

        public bool Closed { get; set; }

        #endregion

        public enum WeekdayEnum
        {
            Monday = 1,
            Tuesday = 2,
            Wednesday = 3,
            Thursday = 4,
            Friday = 5,
            Saturday = 6,
            Sunday = 7
        }
    }
}
