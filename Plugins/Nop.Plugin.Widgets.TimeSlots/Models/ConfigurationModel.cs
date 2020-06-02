using System.ComponentModel.DataAnnotations;
using Nop.Web.Framework.Mvc.ModelBinding;
using Nop.Web.Framework.Models;

namespace Nop.Plugin.Widgets.TimeSlots.Models
{
    public class ConfigurationModel : BaseNopModel
    {
        public int ActiveStoreScopeConfiguration { get; set; }
        
        public int MaxNumberOfOrders { get; set; }
        public bool MaxNumberOfOrders_OverrideForStore { get; set; }

    }
}