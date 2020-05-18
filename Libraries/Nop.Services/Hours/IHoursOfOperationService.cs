using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Mvc.Rendering;
using Nop.Core.Domain.Hours;

namespace Nop.Services.Hours
{
    public partial interface IHoursOfOperationService
    {
        ShopHours GetHoursById(int hoursId);

        List<ShopHours> GetAllShopHours();
        IList<ShopHoursList> GetShophoursList();
        void UpdateShopHours(ShopHours shopHours);
    }
}
