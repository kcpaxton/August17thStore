using Nop.Web.Areas.Admin.Models.Common;
using Nop.Web.Framework.Models;
using Nop.Web.Framework.Mvc.ModelBinding;

namespace Nop.Web.Areas.Admin.Models.Settings
{
    public partial class ShopHoursModel : BaseNopModel, ISettingsModel
    {
        public ShopHoursModel()
        {
            ShopHoursSettings = new ShopHoursSettingsModel();
        }

        public int ActiveStoreScopeConfiguration { get; set; }

        public ShopHoursSettingsModel ShopHoursSettings { get; set; }


    }
}
