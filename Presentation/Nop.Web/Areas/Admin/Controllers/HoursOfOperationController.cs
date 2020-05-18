using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Nop.Services.Hours;
using Nop.Web.Areas.Admin.Factories;
using Nop.Web.Areas.Admin.Infrastructure.Mapper.Extensions;
using Nop.Web.Areas.Admin.Models.Hours;
using Nop.Web.Framework.Controllers;
using Nop.Web.Framework.Mvc.Filters;

namespace Nop.Web.Areas.Admin.Controllers
{
    public partial class HoursOfOperationController : BaseAdminController
    {
        #region Fields
        private readonly IHoursOfOperationService _hoursOfOperationService;
        #endregion

        #region Ctor
        public HoursOfOperationController(IHoursOfOperationService hoursOfOperationService)
        {
            _hoursOfOperationService = hoursOfOperationService;
        }
        #endregion

        public virtual IActionResult List()
        {
            
            ShopHoursModel model = new ShopHoursModel();
            model.ListOfHours = _hoursOfOperationService.GetShophoursList();
            model.ShopHoursObjects = _hoursOfOperationService.GetAllShopHours();


            return View(model);
        }

        [HttpPost]
        public virtual IActionResult List(ShopHoursModel shm)
        {
            
            
            if (ModelState.IsValid)
            {
                foreach(var item in shm.ShopHoursObjects)
                {
                    _hoursOfOperationService.UpdateShopHours(item);
                }

            }
            shm.ListOfHours = _hoursOfOperationService.GetShophoursList();
            return View(shm);
        }
    }
}