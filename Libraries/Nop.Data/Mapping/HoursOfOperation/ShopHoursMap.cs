using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Nop.Core.Domain.HoursOfOperation;

namespace Nop.Data.Mapping.HoursOfOperation
{
    public partial class ShopHoursMap : NopEntityTypeConfiguration<ShopHours>
    {
        #region Methods

        /// <summary>
        /// Configures the entity
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity</param>
        public override void Configure(EntityTypeBuilder<ShopHours> builder)
        {
            builder.ToTable(nameof(ShopHours));
            builder.HasKey(shopHours => shopHours.Id);

            builder.Property(shopHours => shopHours.Weekday).HasMaxLength(20).IsRequired();
            builder.Property(shopHours => shopHours.StartHour).IsRequired();
            builder.Property(shopHours => shopHours.EndHour).IsRequired();
            builder.Property(shopHours => shopHours.Closed).IsRequired();

            base.Configure(builder);
        }
        #endregion
    }
}
