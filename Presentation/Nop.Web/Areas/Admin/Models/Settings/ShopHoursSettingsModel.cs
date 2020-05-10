using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Nop.Web.Framework.Models;
using Nop.Web.Framework.Mvc.ModelBinding;

namespace Nop.Web.Areas.Admin.Models.Settings
{
    public class ShopHoursSettingsModel : BaseNopModel, ISettingsModel
    {
        public int ActiveStoreScopeConfiguration { get; set; }


        [NopResourceDisplayName("Admin.Configuration.Settings.ShopHours.Weekday")]
        public int Weekday { get; set; }

        [NopResourceDisplayName("Admin.Configuration.Settings.ShopHours.StartHour")]
        public System.TimeSpan StartHour { get; set; }

        [NopResourceDisplayName("Admin.Configuration.Settings.ShopHours.EndHour")]
        public System.TimeSpan EndHour { get; set; }
    }
    

}
