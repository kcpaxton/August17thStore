using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Mvc.Rendering;
using Nop.Core.Data;
using Nop.Core.Domain.Hours;
using System.Linq;
using Nop.Core;
using Nop.Services.Events;

namespace Nop.Services.Hours
{
    public partial class HoursOfOperationService : IHoursOfOperationService
    {
        private readonly IRepository<ShopHoursList> _shopHoursListRepository;
        private readonly IRepository<ShopHours> _shopHoursRepository;
        private readonly IEventPublisher _eventPublisher;

        public HoursOfOperationService(IRepository<ShopHoursList> shopHoursListRepository,
            IRepository<ShopHours> shopHoursRepository,
            IEventPublisher eventPublisher)
        {
            _shopHoursListRepository = shopHoursListRepository;
            _shopHoursRepository = shopHoursRepository;
            _eventPublisher = eventPublisher;
        }
        public virtual ShopHours GetHoursById(int hoursId)
        {
            if (hoursId == 0)
                return null;

            return _shopHoursRepository.GetById(hoursId);
        }

        public virtual string GetFriendlyTimeById(int hoursId)
        {
            if (hoursId == 0)
                return null;

            var query = from shl in _shopHoursListRepository.Table
                        where shl.Id == hoursId
                        select shl.FriendlyName;
            return query.First();

            

        }
        public virtual List<ShopHours> GetAllShopHours()
        {
            var query = from sh in _shopHoursRepository.Table
                      orderby sh.Id
                      select sh;
            var shopHours = query.ToList();
            return shopHours;
        }

        public virtual IList<ShopHoursList> GetShophoursList()
        {
            var query = from sh in _shopHoursListRepository.Table
                        select sh;
            var hoursList = query.ToList();
            return hoursList;
        }

        public virtual void UpdateShopHours(ShopHours shopHours)
        {
            if (shopHours == null)
                throw new ArgumentNullException(nameof(shopHours));

            _shopHoursRepository.Update(shopHours);

            //event notification
            _eventPublisher.EntityUpdated(shopHours);
        }
    }
}
