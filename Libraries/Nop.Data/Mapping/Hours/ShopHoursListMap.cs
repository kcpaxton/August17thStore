using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Nop.Core.Domain.Hours;

namespace Nop.Data.Mapping.Hours
{
    public partial class ShopHoursListMap : NopEntityTypeConfiguration<ShopHoursList>
    {
        public override void Configure(EntityTypeBuilder<ShopHoursList> builder)
        {
            builder.ToTable(nameof(ShopHoursList));
            builder.HasKey(shopHoursList => shopHoursList.Id);

            builder.Property(shopHoursList => shopHoursList.ShopTime);

            base.Configure(builder);
        }
    }
}
