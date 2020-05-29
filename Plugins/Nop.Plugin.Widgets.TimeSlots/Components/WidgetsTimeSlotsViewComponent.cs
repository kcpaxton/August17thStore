using System;
using Microsoft.AspNetCore.Mvc;
using Nop.Core;
using Nop.Core.Caching;
using Nop.Plugin.Widgets.TimeSlots.Models;
using Nop.Plugin.Widgets.TimeSlots.Services;
using Nop.Services.Configuration;
using Nop.Services.Media;
using Nop.Web.Framework.Components;

namespace Nop.Plugin.Widgets.TimeSlots.Components
{
    [ViewComponent(Name = "WidgetsTimeSlots")]
    public class WidgetsTimeSlotsViewComponent : NopViewComponent
    {
        private readonly IStoreContext _storeContext;
        private readonly IStaticCacheManager _cacheManager;
        private readonly ISettingService _settingService;
        private readonly IPictureService _pictureService;
        private readonly IWebHelper _webHelper;
        private readonly ITimeSlotService _timeSlotService;

        public WidgetsTimeSlotsViewComponent(IStoreContext storeContext, 
            IStaticCacheManager cacheManager, 
            ISettingService settingService, 
            IPictureService pictureService,
            IWebHelper webHelper,
            ITimeSlotService timeSlotService)
        {
            _storeContext = storeContext;
            _cacheManager = cacheManager;
            _settingService = settingService;
            _pictureService = pictureService;
            _webHelper = webHelper;
            _timeSlotService = timeSlotService;
        }

        public IViewComponentResult Invoke(string widgetZone, object additionalData)
        {
            var timeSlotsSettings = _settingService.LoadSetting<TimeSlotsSettings>(_storeContext.CurrentStore.Id);

            var model = new ReservationSlotsModel();

            model.ListOfTimeSlots = _timeSlotService.GetAllTimeSlots();

            model.ListOfTimes = _timeSlotService.GetAllTimes(model.ListOfTimeSlots);
            return View("~/Plugins/Widgets.TimeSlots/Views/PublicInfo.cshtml", model);
        }
    }
}
