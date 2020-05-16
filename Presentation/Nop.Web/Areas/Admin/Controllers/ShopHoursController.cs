using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Nop.Core.Domain.HoursOfOperation;
using Nop.Services.HoursOfOperation;
using Nop.Web.Areas.Admin.Factories;
using OfficeOpenXml.FormulaParsing.Excel.Functions.Text;

namespace Nop.Web.Areas.Admin.Controllers
{
    public partial class ShopHoursController : BaseAdminController
    {
        private readonly IShopHoursService _shopHoursService;
        private readonly IShopHoursModelFactory _shopHoursModelFactory;
        #region Ctor
        public ShopHoursController(IShopHoursService shopHoursService, IShopHoursModelFactory shopHoursModelFactory)
        {
            _shopHoursService = shopHoursService;
            _shopHoursModelFactory = shopHoursModelFactory;
        }
        #endregion
        public IActionResult Display()
        {
            //prepare model
            ViewBag.TimeList = GetTimeSpans().ToList();
            var shopHours = _shopHoursService.GetAllShopHours();

            //var shopHours = _shopHoursService.GetShopHoursById(1);
            var model = _shopHoursModelFactory.PrepareShopHoursModel();

         

            return View(model);
        }
        public List<string> GetTimeIntervals()
        {
            List<string> timeIntervals = new List<string>();
            TimeSpan startTime = new TimeSpan(0, 0, 0);
            DateTime startDate = new DateTime(DateTime.MinValue.Ticks); // Date to be used to get shortTime format.
            for (int i = 0; i < 48; i++)
            {
                int minutesToBeAdded = 30 * i;      // Increasing minutes by 30 minutes interval
                TimeSpan timeToBeAdded = new TimeSpan(0, minutesToBeAdded, 0);
                TimeSpan t = startTime.Add(timeToBeAdded);
                DateTime result = startDate + t;
                timeIntervals.Add(result.ToShortTimeString());      // Use Date.ToShortTimeString() method to get the desired format                
            }
            return timeIntervals;
        }

        public List<SelectListItem> GetTimeSpans()
        {
            List<TimeSpan> timeSpanList = new List<TimeSpan>();
            timeSpanList.Add(TimeSpan.FromHours(0));

            TimeSpan halfHourCounter = new TimeSpan(0, 30, 0);
            TimeSpan current = new TimeSpan(0, 30, 0);

            while (timeSpanList.First() != current && current.Days != 1)
            {
                timeSpanList.Add(current);
                current += halfHourCounter;
            }

            var listItems = new List<SelectListItem>();
            foreach(var item in timeSpanList)
            {
                listItems.Add(new SelectListItem { Text = item.ToString(), Value = item.ToString(@"hh\:mm"), Selected = false });
            }


            return listItems;

        }
    }
}