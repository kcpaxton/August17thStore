using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Nop.Core.Domain.Hours;
using Nop.Web.Framework.Models;

namespace Nop.Web.Areas.Admin.Models.Hours
{
    public partial class ShopHoursModel : BaseNopEntityModel
    {
        public List<ShopHours> ShopHoursObjects { get; set; }

        public IList<ShopHoursList> ListOfHours { get; set; }
    }
}
