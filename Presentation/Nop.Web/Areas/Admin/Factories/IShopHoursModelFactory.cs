using System.Collections.Generic;
using Nop.Core.Domain.HoursOfOperation;

namespace Nop.Web.Areas.Admin.Factories
{
    public partial interface IShopHoursModelFactory
    {
        /// <summary>
        /// Prepare Shop Hours model
        /// </summary>
        /// <param name="model">ShopHours model</param>
        /// <returns>ShopHours model</returns>
        List<ShopHours> PrepareShopHoursModel();
    }
}