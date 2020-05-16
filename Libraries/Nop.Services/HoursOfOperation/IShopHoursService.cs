using System.Collections.Generic;
using Nop.Core.Domain.HoursOfOperation;

namespace Nop.Services.HoursOfOperation
{
    public partial interface IShopHoursService
    {
        ShopHours GetShopHoursById(int shopHoursId);
        /// <summary>
        /// Gets the shops hours
        /// </summary>
        /// <returns>Shop Hours list</returns>
        IList<ShopHours> GetAllShopHours();
    }
}
