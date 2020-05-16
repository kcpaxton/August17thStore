using System;
using System.Collections.Generic;
using System.Text;
using Nop.Core.Data;
using Nop.Core.Domain.HoursOfOperation;
using System.Linq;

namespace Nop.Services.HoursOfOperation
{
    public partial class ShopHoursService : IShopHoursService
    {
        #region Fields
        private readonly IRepository<ShopHours> _shopHoursRepository;
        #endregion

        #region ctor
        public ShopHoursService(IRepository<ShopHours> shopHoursRepository)
        {
            _shopHoursRepository = shopHoursRepository;
        }
        #endregion

        public virtual ShopHours GetShopHoursById(int shopHoursId)
        {
            if (shopHoursId == 0)
                return null;

            return _shopHoursRepository.GetById(shopHoursId);
        }


        /// <summary>
        /// Gets the stores hours of operation 
        ///  </summary>
        /// <returns>Store hours list</returns>
        public virtual IList<ShopHours> GetAllShopHours()
        {
           
            var query = from sh in _shopHoursRepository.Table
                        orderby sh.Id
                        select sh;
            var shopHours = query.ToList();
            return shopHours;
        }
    }
}
