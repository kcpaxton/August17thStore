using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Nop.Core.Domain.Hours;

namespace Nop.Data.Mapping.Hours
{
    public partial class ShopHoursMap : NopEntityTypeConfiguration<ShopHours>
    {
        public override void Configure(EntityTypeBuilder<ShopHours> builder)
        {
            builder.ToTable(nameof(ShopHours));
            builder.HasKey(shopHours => shopHours.Id);

            builder.Property(shopHours => shopHours.Weekday);
            builder.Property(shopHours => shopHours.StartHourId);
            builder.Property(shopHours => shopHours.EndHourID);
            builder.Property(shopHours => shopHours.Closed);

            base.Configure(builder);
        }
    }
}
