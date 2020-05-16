using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Nop.Core.Domain.HoursOfOperation;
using Nop.Services.HoursOfOperation;
using Nop.Web.Areas.Admin.Infrastructure.Mapper.Extensions;
using Nop.Web.Areas.Admin.Models.ShopHours;
using Nop.Web.Framework.Models.Extensions;

namespace Nop.Web.Areas.Admin.Factories
{
    public partial class ShopHoursModelFactory : IShopHoursModelFactory
    {
        private readonly IShopHoursService _shopHoursService;

        public ShopHoursModelFactory(IShopHoursService shopHoursService)
        {
            _shopHoursService = shopHoursService;
        }

        public List<ShopHours> PrepareShopHoursModel()
        {
            var shopHoursList = _shopHoursService.GetAllShopHours().ToList();






            //model = shopHours.ToModel<ShopHoursModel>();
            //var shopHoursModel = shopHours.ToModel<ShopHoursModel>();

            return shopHoursList;
        }

    }
}
